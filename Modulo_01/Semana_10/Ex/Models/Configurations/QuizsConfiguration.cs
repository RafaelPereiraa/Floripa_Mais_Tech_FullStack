using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex.Models.Configurations
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quizs>
    {
        public void Configure(EntityTypeBuilder<Quizs> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Title).HasMaxLength(100).IsRequired();

            builder.HasOne(q => q.Discipline).WithMany(d => d.Quizs).HasForeignKey(q => q.DisciplineId);
        }
    }
}
