using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EX_01.models.configurations
{
    public class MaeConfiguration : IEntityTypeConfiguration<Mae>
    {
        public void Configure(EntityTypeBuilder<Mae> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Nome).HasMaxLength(60).IsRequired();
            builder.Property(m => m.Endereco).HasMaxLength(300).IsRequired();
            builder.Property(m => m.Telefone).HasMaxLength(20).IsRequired();
            builder.Property(m => m.Data_Nascimento).IsRequired();

            builder.HasMany(m => m.Bebes).WithOne(b => b.Mae).HasForeignKey(b => b.Id_Mae);
        }
    }
}
