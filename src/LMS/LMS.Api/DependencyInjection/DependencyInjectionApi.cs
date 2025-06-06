using LMS.Infrastructure.DependencyInjection;

namespace LMS.Api.DependencyInjection
{
    public static class DependencyInjectionApi
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI().
                AddInfrastructureDI().
                AddCoreDI();
            return services;
        }
    }
}
