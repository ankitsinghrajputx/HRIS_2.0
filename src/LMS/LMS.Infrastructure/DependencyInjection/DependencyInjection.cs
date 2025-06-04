using LMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<LmsDbContext>(options =>
            {
                options.UseSqlServer("Server=6826ANKITK5288L\\SQLEXPRESS;Database=LeaveDB;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true");
            });
            return services;
        }
    }
}
