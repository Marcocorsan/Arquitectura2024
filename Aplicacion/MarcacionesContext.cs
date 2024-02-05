using Aplicacion.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class MarcacionesContext : DbContext
    {
        public MarcacionesContext(DbContextOptions<MarcacionesContext> opts)
            : base(opts) { }
        public DbSet<Marcaciones> Marcaciones => Set<Marcaciones>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marcaciones>().ToTable("as_Marcaciones");
            modelBuilder.Entity<Marcaciones>().HasKey(t => t.idMarcaciones);            
        }
    }
}
