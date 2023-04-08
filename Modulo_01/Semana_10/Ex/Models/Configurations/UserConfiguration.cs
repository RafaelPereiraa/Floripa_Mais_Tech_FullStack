using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex.Models.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).HasMaxLength(60).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(u => u.Password).HasMaxLength(100).IsRequired();

            builder.HasOne(u => u.Teacher).WithOne(t => t.User).HasForeignKey<Teachers>(t => t.UserId);
            builder.HasOne(u => u.Student).WithOne(s => s.User).HasForeignKey<Students>(s => s.UserId);
        }
    }

}
