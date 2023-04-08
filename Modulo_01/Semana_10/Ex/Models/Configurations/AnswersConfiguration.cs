using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex.Models.Configurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answers>
    {
        public void Configure(EntityTypeBuilder<Answers> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Answer).HasMaxLength(500).IsRequired();
            builder.Property(a => a.Score).HasColumnType("decimal(4,3)").IsRequired();
            builder.Property(a => a.Observation).HasMaxLength(1000).IsRequired(false);

            builder.HasOne(a => a.Question).WithMany(q => q.Answers).HasForeignKey(a => a.QuestionId);
            builder.HasOne(a => a.Student).WithMany(s => s.Answers).HasForeignKey(a => a.StudentId);

            builder.Property(a => a.Image)
            .HasColumnType("varbinary(MAX)")
            .IsRequired(false);
        }
    }
}
