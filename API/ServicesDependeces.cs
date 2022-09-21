using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Microsoft.EntityFrameworkCore;
using Data.Repositories.Interfaces;
using Data.Repositories;

namespace Infra
{
    public static class ServicesDependeces
    {

        public static void ConfigurationDatabase(this IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

            services.AddDbContext<AppDbContext>(opt => opt.UseMySql("server=localhost;user=root;password=1234;database=ef", serverVersion));
        }


        public static void RepositoriesDependeces(this IServiceCollection services)
        {
            services.AddScoped<IMedicoRepository, MedicoRepository>();
        }
    }
}
