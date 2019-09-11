using System;
using BlogANetReact.Repository;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace BlogANetReact.Web.Api.Extensions
{
    public static class DependencyInjection
    {
        public static void RegisterRepositoriesWithScopedLifetime(this IServiceCollection services)
        {
            services.Scan(
                scan => scan.FromAssemblyOf<ITagsRepository>()
                .AddClasses()
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        }
    }
}
