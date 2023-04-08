using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex.Models.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Disciplines>
    {
        public void Configure(EntityTypeBuilder<Disciplines> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Department).HasMaxLength(100).IsRequired();
            builder.Property(d => d.Name).HasMaxLength(100).IsRequired();

            builder.HasOne(d => d.Teachers).WithMany(t => t.Disciplines).HasForeignKey(d => d.TeacherId);
            builder.HasMany(d => d.StudentsDisciplines).WithOne(sd => sd.Discipline).HasForeignKey(sd => sd.DisciplineId);
            builder.HasMany(d => d.Quizs).WithOne(q => q.Discipline).HasForeignKey(q => q.DisciplineId);
        }
    }
}
