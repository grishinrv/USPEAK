using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Diagnostics.CodeAnalysis;
using Uspeak.Data.Models;
using Uspeak.Data.Models.Courses;
using Uspeak.Data.Models.Infrastructure;
using Uspeak.Data.Models.Study;
using Uspeak.Data.Models.Tests;
using Uspeak.Data.Models.Users;

namespace Uspeak.Persistence
{
    public interface IUspeakDbContext: IDisposable
    {
        EntityEntry Entry([NotNull] object entity);
        EntityEntry<TEntity> Entry<TEntity>([NotNull] TEntity entity) where TEntity : class;
        DatabaseFacade Database { get; }
        DbSet<Course> Courses { get; }
        //DbSet<EventInstance> Events { get; }
        DbSet<RuntimeConfiguration> Config { get; }
        //DbSet<Group> Groups { get; }
        //DbSet<Lesson> Lessons { get; }
        //DbSet<LessonStudentPresence> Presences { get; }
        //DbSet<Student> Students { get; }
        //DbSet<Teacher> Teachers { get; }
        //DbSet<AnswerOption> AnswerOptions { get; }
        //DbSet<QuestionSettings> QuestionSettings { get; }
        //DbSet<TestSettings> TestSettings { get; }
        //DbSet<User> Users { get; }
        DbSet<Entity> Entities { get; }
        DbSet<Tag> Tags { get; }
        DbSet<Image> Images { get; }
        DbSet<RuntimeConfiguration> RuntimeConfig { get; }
    }
}
