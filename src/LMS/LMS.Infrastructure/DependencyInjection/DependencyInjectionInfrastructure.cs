using LMS.Core.Interfaces;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories;
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
    public static class DependencyInjectionInfrastructure
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<LmsDbContext>(options =>
            {
                options.UseSqlServer("Server=6826ANKITK5288L\\SQLEXPRESS;Database=HRIS_Leave;User Id=sa;Password=Microsoft#1234;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
            });

            services.AddScoped<ILeaveRepository, LeaveRepository>();
            return services;
        }
    }
}
