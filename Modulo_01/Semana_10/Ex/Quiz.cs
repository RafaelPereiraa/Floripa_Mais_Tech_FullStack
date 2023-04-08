using Ex.Models;
using Ex.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IO;

namespace Ex;

public class Quiz : DbContext
{
    public Quiz(DbContextOptions<Quiz> options) : base(options)
    {
    }
    public DbSet<Answers> Answers{ get; set; }
    public DbSet<Disciplines> Disciplines { get; set; }
    public DbSet<Questions> Questions { get; set; }
    public DbSet<Quizs> Quizs { get; set; }
    public DbSet<Students> Students { get; set; }
    public DbSet<StudentsDisciplines> StudentsDisciplines { get; set; }
    public DbSet<Teachers> Teachers { get; set; }
    public DbSet<Users> Users { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new TeachersConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new StudentsDisciplinesConfiguration());
        modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
        modelBuilder.ApplyConfiguration(new QuizConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionConfiguration());
        modelBuilder.ApplyConfiguration(new AnswerConfiguration());
    }

}

