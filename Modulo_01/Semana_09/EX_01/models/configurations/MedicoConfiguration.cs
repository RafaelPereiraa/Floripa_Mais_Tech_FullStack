using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EX_01.models.configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.CRM).HasMaxLength(15).IsRequired();
            builder.Property(m => m.Nome).HasMaxLength(60).IsRequired();
            builder.Property(m => m.Celular).HasMaxLength(15).IsRequired();
            builder.Property(m => m.Especialidade).HasMaxLength(100).IsRequired();

            builder.HasMany(m => m.Partos).WithOne(p => p.Medico).HasForeignKey(p => p.Id_Medico);
        }
    }
}
