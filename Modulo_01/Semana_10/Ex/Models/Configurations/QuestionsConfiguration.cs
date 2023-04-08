using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex.Models.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Questions>
    {
        public void Configure(EntityTypeBuilder<Questions> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Enunciation).HasMaxLength(500).IsRequired();
            builder.Property(q => q.Weight).HasColumnType("decimal(5, 2)").IsRequired();

            builder.HasOne(q => q.Quizs).WithMany(qz => qz.Questions).HasForeignKey(q => q.QuizId);

            builder.HasMany(q => q.Answers).WithOne(a => a.Question).HasForeignKey(a => a.QuestionId);
        }
    }

}
