using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex.Models.Configurations
{
    public class StudentsDisciplinesConfiguration : IEntityTypeConfiguration<StudentsDisciplines>
    {
        public void Configure(EntityTypeBuilder<StudentsDisciplines> builder)
        {
            builder.HasKey(sd => new { sd.StudentId, sd.DisciplineId });

            builder.HasOne(sd => sd.Student).WithMany(s => s.StudentDisciplines).HasForeignKey(sd => sd.StudentId);
            builder.HasOne(sd => sd.Discipline).WithMany(d => d.StudentsDisciplines).HasForeignKey(sd => sd.DisciplineId);
        }
    }

}
