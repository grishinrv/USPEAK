using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Uspeak.Data.Models;
using Uspeak.Data.Models.Courses;
using Uspeak.Data.Models.Tests;
using Uspeak.Data.Models.Users;

namespace Uspeak.Persistence
{
    public interface IUspeakDbContext: IDisposable
    {
        EntityEntry Entry([NotNull] object entity);
        EntityEntry<TEntity> Entry<TEntity>([NotNull] TEntity entity) where TEntity : class;
        DbSet<Course> Courses { get; }
        DbSet<EventInstance> Events { get; }
        DbSet<AnswerOption> AnswerOptions { get; }
        DbSet<QuestionSettings> QuestionSettings { get; }
        DbSet<TestSettings> TestSettings { get; }
        DbSet<User> Users { get; }
        DbSet<Entity> Entities { get; }
        DbSet<Tag> Tags { get; }
    }
}
