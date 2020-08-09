using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uspeak.Data.Models;
using Uspeak.Data.Models.Courses;
using Uspeak.Services;

namespace Uspeak.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        public Task<List<Course>> GetCourses(Guid subjectId) => _courseRepository.GetCoursesByTagId(subjectId);
    }
}
