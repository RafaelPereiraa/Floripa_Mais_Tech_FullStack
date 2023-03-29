using EX_01.models;
using EX_01.models.configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EX_01
{
    public class Bercario : DbContext
    {
        public Bercario(DbContextOptions<Bercario> options) : base(options)
        {
        }
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BebeConfiguration());
            modelBuilder.ApplyConfiguration(new MaeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration(new PartoConfiguration());
        }
    }
}
