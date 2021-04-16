using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uspeak.Data.Models;
using Uspeak.Data.Models.Courses;
using Uspeak.Persistence;

namespace Uspeak.Services
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCoursesByTagId(Guid subjectId);
    }

    public class CourseRepository : ICourseRepository
    {
        private readonly IContextFactory _contextFactory;

        public CourseRepository(IContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<Course>> GetCoursesByTagId(Guid subjectId)
        {
            using (var context = _contextFactory.Create())
            {
                return await context.Courses.Where(c =>                        
                        (context.Entities.Where(x => x.EnityKind == EntityType.Course
                        && x.EntityTags.Any(t => t.TagId == subjectId))
                        .Select(e => e.Id)).Contains(c.Id))
                    .ToListAsync();
            }
        }
    }
}