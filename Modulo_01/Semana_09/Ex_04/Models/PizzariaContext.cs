using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ex_04.Models;

public partial class PizzariaContext : DbContext
{
    public PizzariaContext()
    {
    }

    public PizzariaContext(DbContextOptions<PizzariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Borda> Bordas { get; set; }

    public virtual DbSet<Massa> Massas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<PizzaSabore> PizzaSabores { get; set; }

    public virtual DbSet<Sabore> Sabores { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-H9AB6P5;Database=PIZZARIAS09;User ID=sa;Password=12345;Trusted_Connection=False; Encrypt=False;Trust Server Certificate=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Borda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__bordas__3213E83F6B94D7FA");

            entity.ToTable("bordas");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Massa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__massas__3213E83FC8109EBB");

            entity.ToTable("massas");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pedidos__3213E83FB56B464D");

            entity.ToTable("pedidos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdPizza).HasColumnName("id_pizza");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");

            entity.HasOne(d => d.IdPizzaNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdPizza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pedidos__id_pizz__5441852A");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pedidos__id_stat__5535A963");
        });

        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza__3213E83FD264328A");

            entity.ToTable("Pizza");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdBordas).HasColumnName("id_bordas");
            entity.Property(e => e.IdMassas).HasColumnName("id_massas");

            entity.HasOne(d => d.IdBordasNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdBordas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pizza__id_bordas__4F7CD00D");

            entity.HasOne(d => d.IdMassasNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdMassas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pizza__id_massas__4E88ABD4");
        });

        modelBuilder.Entity<PizzaSabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pizza_sa__3213E83F536EAAEF");

            entity.ToTable("pizza_sabores");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdPizza).HasColumnName("id_pizza");
            entity.Property(e => e.IdSabores).HasColumnName("id_sabores");

            entity.HasOne(d => d.IdPizzaNavigation).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.IdPizza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pizza_sab__id_pi__59FA5E80");

            entity.HasOne(d => d.IdSaboresNavigation).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.IdSabores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pizza_sab__id_sa__5AEE82B9");
        });

        modelBuilder.Entity<Sabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sabores__3213E83F5DDD1C61");

            entity.ToTable("sabores");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__status__3213E83FAF841F35");

            entity.ToTable("status");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
