using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Medico> Medico { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<UnidadeSaude> UnidadeSaude { get; set; }
        public DbSet<EspecialidadeMedico> EspecialidadeMedico { get; set; }
        public DbSet<UnidadeMedico> UnidadeMedico { get; set; }
        public DbSet<BuscaEspecialidade> BuscaEspecialidade { get; set; }
        public DbSet<Plantao> Plantaos { get; set; }



        
    }
}
