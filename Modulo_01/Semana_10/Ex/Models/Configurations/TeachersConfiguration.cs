using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex.Models.Configurations
{
    public class TeachersConfiguration : IEntityTypeConfiguration<Teachers>
    {
        public void Configure(EntityTypeBuilder<Teachers> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Department).HasMaxLength(100).IsRequired();

            builder.HasOne(t => t.User).WithOne().HasForeignKey<Teachers>(t => t.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(t => t.Disciplines).WithOne(d => d.Teachers).HasForeignKey(d => d.TeacherId);
        }
    }

}
