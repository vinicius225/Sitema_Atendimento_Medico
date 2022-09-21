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
        public AppDbContext()
        {

        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<UnidadeSaude> UnidadeSaudes { get; set; }
        public DbSet<EspecialidadeMedico> EspecialidadeMedicos { get; set; }
        public DbSet<UnidadeMedico> UnidadeMedicos { get; set; }
        public DbSet<BuscaEspecialidade> BuscaEspecialidades { get; set; }
        public DbSet<Plantao> Plantaos { get; set; }



        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("created_at") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    if (entry.Entity.GetType().GetProperty("created_at") != null)
                    {
                        if (entry.Property("created_at").CurrentValue == null)
                            entry.Property("created_at").CurrentValue = DateTime.Now;
                    }


                    if (entry.Entity.GetType().GetProperty("updated_at") != null)
                        entry.Property("updated_at").IsModified = false;
                }

                if (entry.State == EntityState.Modified)
                {
                    if (entry.Entity.GetType().GetProperty("created_at") != null)
                        entry.Property("created_at").IsModified = false;

                    if (entry.Entity.GetType().GetProperty("updated_at") != null)
                        entry.Property("updated_at").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
