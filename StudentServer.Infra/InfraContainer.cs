using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentServer.Infra.Persistence;
using StudentServer.Infra.Persistence.Repositories;
using StudentServer.Application.Contracts;
using Microsoft.EntityFrameworkCore;

namespace StudentServer.Infra
{
    public static class InfraContainer
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("AppConnectionString")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
