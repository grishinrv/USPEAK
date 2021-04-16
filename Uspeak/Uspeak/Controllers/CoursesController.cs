using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uspeak.Data.Models.Courses;
using Uspeak.Services;

namespace Uspeak.Controllers
{
    [Route("api/Courses")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet("BySubject/{id}")]
        public async Task<List<Course>> GetBySubject(string id)
        {
            return await _courseRepository.GetCoursesByTagId(Guid.Parse(id));
        } 
    }
}
