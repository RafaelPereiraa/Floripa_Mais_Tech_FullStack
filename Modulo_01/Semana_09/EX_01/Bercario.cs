using EX_01.models;
using Microsoft.EntityFrameworkCore;

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
            modelBuilder.Entity<Bebe>()
                .HasOne(b => b.Mae)
                .WithMany(m => m.Bebes)
                .HasForeignKey(b => b.MaeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Bebe>()
                .HasOne(b => b.Parto)
                .WithMany(p => p.Bebes)
                .HasForeignKey(b => b.PartoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Parto>()
                .HasOne(p => p.Medico)
                .WithMany(m => m.Partos)
                .HasForeignKey(p => p.MedicoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
