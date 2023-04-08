using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex.Models.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasOne(s => s.User).WithOne().HasForeignKey<Students>(s => s.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(s => s.StudentDisciplines).WithOne(sd => sd.Student).HasForeignKey(sd => sd.StudentId);
        }
    }
}
