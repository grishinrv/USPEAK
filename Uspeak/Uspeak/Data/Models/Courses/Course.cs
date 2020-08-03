using System;
using System.Collections.Generic;
using Uspeak.Data.Models.Tests;

namespace Uspeak.Data.Models.Courses
{
    public class Course : IViewable, IPersistable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<TestSettings> Tests { get; set; }
        public Guid PromoImageId { get; set; }
        public Image PromoImage { get; set; }
        public string CssClassesString { get; set; }
        public int LessonsQuantity { get; set; }
        public int LessonDurationMinutes { get; set; }
    }
}
