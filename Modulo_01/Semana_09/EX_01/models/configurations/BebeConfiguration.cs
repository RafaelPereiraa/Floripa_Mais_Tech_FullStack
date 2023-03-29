using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EX_01.models.configurations
{
    public class BebeConfiguration : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Data_Nascimento).IsRequired();
            builder.Property(b => b.Peso_Nascimento).HasColumnType("decimal(4,3)").IsRequired();
            builder.Property(b => b.Altura).IsRequired();

            builder.HasOne(b => b.Mae).WithMany(m => m.Bebes).HasForeignKey(b => b.Id_Mae);
            builder.HasOne(b => b.Parto).WithMany(p => p.Bebes).HasForeignKey(b => b.Id_Parto);
        }
    }
}
