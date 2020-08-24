using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uspeak.Data.Models.Courses;
using Uspeak.Services;

namespace Uspeak.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet("Get/{subjectId}")]
        public async Task<List<Course>> GetCourses(Guid subjectId)
        { 
            return await _courseRepository.GetCoursesByTagId(subjectId);
        } 
    }
}
