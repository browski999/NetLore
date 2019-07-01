using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace NetLore.Infrastructure.Extensions
{
    public static class AutoMapperRegistrationExtensions
    {
        public static IServiceCollection AddAutoMapperWithProfiles(this IServiceCollection services, Assembly assembly)
        {
            services.AddAutoMapperWithProfiles(Assembly.GetAssembly(typeof(AutoMapperRegistrationExtensions)));
            return services;
        }

    }
}
