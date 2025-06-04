using LMS.Infrastructure.DependencyInjection;

namespace LMS.Api.DependencyInjection
{
    public static class DependencyInjection
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
