using Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Infraestructure.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataBaseContext).Assembly);
        }
    }
}
