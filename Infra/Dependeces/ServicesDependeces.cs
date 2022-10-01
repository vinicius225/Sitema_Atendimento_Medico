﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Microsoft.EntityFrameworkCore;
using Data.Repositories.Interfaces;
using Data.Repositories;

namespace Infra.Dependeces
{
    public static class ServicesDependeces
    {

        public static IServiceCollection ConfigurationDatabaseProject(this IServiceCollection services)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 30));

            services.AddDbContext<AppDbContext>(options => options.UseMySql("server=sambd.mysql.database.azure.com;user=tcc@sambd;password=Sam2022_8p;database=upa", serverVersion));

            return services;
        }
        public static IServiceCollection RepositoriesDependeces(this IServiceCollection services)
        {
            services.AddScoped<IMedicoRepository, MedicoRepository>();
            services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();

            return services;

        }


    }
}
