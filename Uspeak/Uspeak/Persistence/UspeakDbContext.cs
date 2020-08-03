using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Uspeak.Data.Models;
using Uspeak.Data.Models.Courses;
using Uspeak.Data.Models.Infrastructure;
using Uspeak.Data.Models.Study;
using Uspeak.Data.Models.Tests;
using Uspeak.Data.Models.Users;

namespace Uspeak.Persistence
{
    public class UspeakDbContext : DbContext, IUspeakDbContext
    {
        public UspeakDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected sealed override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            //modelBuilder.Entity<Course>()
            //    .HasKey()
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<EventInstance> Events { get; set; }

        public DbSet<RuntimeConfiguration> Config { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<LessonStudentPresence> Presences { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<AnswerOption> AnswerOptions { get; set; }

        public DbSet<QuestionSettings> QuestionSettings { get; set; }

        public DbSet<TestSettings> TestSettings { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Entity> Entities { get; set; }

        public DbSet<Tag> Tags { get; set; }
        
        public DbSet<Image> Images { get; set; }
    }
}
