using MediatR.NotificationPublishers;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Api.DependencyInjection
{
    public static class DependencyInjectionApplication
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjectionApplication).Assembly);
                cfg.NotificationPublisher = new TaskWhenAllPublisher();
            });

            return services;
        }
    }
}
