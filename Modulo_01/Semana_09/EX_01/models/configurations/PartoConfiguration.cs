using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EX_01.models.configurations
{
    public class PartoConfiguration : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DataParto).IsRequired();
            builder.Property(p => p.HorarioParto).IsRequired();

            builder.HasOne(p => p.Medico).WithMany(m => m.Partos).HasForeignKey(p => p.Id_Medico);
            builder.HasMany(p => p.Bebes).WithOne(b => b.Parto).HasForeignKey(b => b.Id_Parto);
        }
    }
}
