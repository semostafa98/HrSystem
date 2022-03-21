using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using HR.LeaveManagment.Application.Persistence.Contracts;
using HR.LeaveManagment.Persistence.Repositories;

namespace HR.LeaveManagment.Persistence
{
    public static class PresistenceServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LeaveManagmentDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LeaveManagmentConnectionString")));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<ILeaveAllocationRepository, LeaveAllocayionRepositpry>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();

            return services;


        }
    }
}
