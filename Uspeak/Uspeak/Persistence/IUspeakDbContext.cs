using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Uspeak.Data.Models;
using Uspeak.Data.Models.Courses;
using Uspeak.Data.Models.Tests;
using Uspeak.Data.Models.Users;

namespace Uspeak.Persistence
{
    public interface IUspeakDbContext
    {


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
