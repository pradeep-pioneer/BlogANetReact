using System.Linq;
using System.Threading.Tasks;
using BlogANetReact.Data.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlogANetReact.Data.Entities.Auth;
using Microsoft.AspNetCore.Identity;

namespace BlogANetReact.Migrations.Code
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("BlogDb");
            services.AddDbContext<BlogDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            services.AddIdentity<UserEntity, RoleEntity>()
                .AddEntityFrameworkStores<BlogDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            var migrated = Migrate(app).Result;

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"The database migration done: {migrated}");
                });
            });
            
        }

        private async Task<bool> Migrate(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<BlogDbContext>();
                var created = db.Database.EnsureCreated();
                if(created)
                {
                    db.Database.Migrate();
                }
                await SeedData(db, app, serviceScope);
                return created;
            }
        }

        private async Task SeedData(BlogDbContext context, IApplicationBuilder app, IServiceScope scope)
        {
            var dbRoles = await context.Roles.ToListAsync();
            var missingRoles = Data.RoleEntities.Where(requiredRole => !dbRoles.Any(dbRole => dbRole.Name == requiredRole.Name));
            if(missingRoles.Any())
            {
                var roleManager = scope.ServiceProvider.GetService<RoleManager<RoleEntity>>();
                foreach (var item in missingRoles)
                {
                    await roleManager.CreateAsync(item);
                }
            }
            var dbUsers = await context.Users.ToListAsync();
            var missingUsers = Data.Users.Where(requiredUser => !dbUsers.Any(dbUser => dbUser.UserName == requiredUser.UserName));
            if(missingUsers.Any())
            {
                var userManager = scope.ServiceProvider.GetService<UserManager<UserEntity>>();
                foreach (var item in missingUsers)
                {
                    var userResult = await userManager.CreateAsync(item);
                    if(userResult.Succeeded && item.UserName == "Anonymous")
                    {
                        var userRecord = await userManager.FindByNameAsync(item.UserName);
                        await userManager.AddToRoleAsync(userRecord, "Anonymous");
                    }
                }
            }

            var dbLanguages = await context.Languages.ToListAsync();
            var missingLanguages = Data.Languages.Where(requiredLanguage => !dbLanguages.Any(dbLanguage => dbLanguage.LanguageCode == requiredLanguage.LanguageCode));
            if(missingLanguages.Any())
            {
                foreach (var item in missingLanguages)
                {
                    await context.Languages.AddAsync(item);
                }
            }
            await context.SaveChangesAsync();
        }
    }
}
