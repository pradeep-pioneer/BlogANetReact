using System;
using System.Linq;
using System.Threading.Tasks;
using BlogANetReact.Data.Entities.Auth;
using BlogANetReact.Data.Model;
using BlogANetReact.Migrations.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlogANetReact.Web.Api.Extensions
{
    public static class DbContextExtensions
    {
        public static async Task<bool> MigrateDb(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<BlogDbContext>();
                var created = db.Database.EnsureCreated();
                if (created)
                {
                    db.Database.Migrate();
                }
                await SeedData(db, app, serviceScope);
                return created;
            }
        }

        private static async Task SeedData(BlogDbContext context, IApplicationBuilder app, IServiceScope scope)
        {
            var dbRoles = await context.Roles.ToListAsync();
            var missingRoles = Masters.RoleEntities.Where(requiredRole => !dbRoles.Any(dbRole => dbRole.Name == requiredRole.Name));
            if (missingRoles.Any())
            {
                var roleManager = scope.ServiceProvider.GetService<RoleManager<RoleEntity>>();
                foreach (var item in missingRoles)
                {
                    await roleManager.CreateAsync(item);
                }
            }
            var dbUsers = await context.Users.ToListAsync();
            var missingUsers = Masters.Users.Where(requiredUser => !dbUsers.Any(dbUser => dbUser.UserName == requiredUser.UserName));
            if (missingUsers.Any())
            {
                var userManager = scope.ServiceProvider.GetService<UserManager<UserEntity>>();
                foreach (var item in missingUsers)
                {
                    var userResult = await userManager.CreateAsync(item);
                    if (userResult.Succeeded && item.UserName == "Anonymous")
                    {
                        var userRecord = await userManager.FindByNameAsync(item.UserName);
                        await userManager.AddToRoleAsync(userRecord, "Anonymous");
                    }
                }
            }

            var dbLanguages = await context.Languages.ToListAsync();

            var missingLanguages = Masters.Languages.Where(requiredLanguage => !dbLanguages.Any(dbLanguage => dbLanguage.LanguageCode == requiredLanguage.LanguageCode));
            if (missingLanguages.Any())
            {
                await context.Languages.AddRangeAsync(missingLanguages);
            }
            await context.SaveChangesAsync();

            var dbLocales = await context.Locales.ToListAsync();
            var missingLocales = Masters.Locales.Where(requiredLocale => !dbLocales.Any(dbLocale => dbLocale.LCID == requiredLocale.LCID));
            var languages = await context.Languages.ToListAsync();
            if (missingLocales.Any())
            {
                foreach (var item in missingLocales)
                {
                    item.CreatedBy = Masters.CreatedBy;
                    item.CreatedOn = Masters.TimeStamp;
                    var language = languages.FirstOrDefault(x => x.LanguageCode == item.LCID.Split('-')[0]);
                    if (language != null)
                    {
                        item.Language = language;
                    }
                    await context.Locales.AddAsync(item);
                }
            }
            await context.SaveChangesAsync();
        }
    }
}
