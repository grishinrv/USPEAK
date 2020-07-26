using System;
using System.Collections.Generic;
using Uspeak.Data.Models.Tests;

namespace Uspeak.Data.Models.Courses
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<TestSettings> Tests { get; set; }
    }
}
