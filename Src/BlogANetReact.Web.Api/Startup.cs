using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using BlogANetReact.Web.Api.Extensions;
using BlogANetReact.Data.Model;
using BlogANetReact.Data.Entities.Auth;
using BlogANetReact.Web.Api.Schemas;
using BlogANetReact.Repository;

namespace BlogANetReact.Web.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Environment.GetEnvironmentVariable("BLOG_CONNECTION_STRING");
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Could not start without connection string.");
            services.AddDbContext<BlogDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            },ServiceLifetime.Transient);
            services.RegisterRepositoriesWithScopedLifetime();
            services.AddIdentity<UserEntity, RoleEntity>()
                .AddEntityFrameworkStores<BlogDbContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            var migrated = app.MigrateDb().Result;
        }
    }
}
