using System;
using System.Collections.Generic;
using Uspeak.Data.Models.Courses;

namespace Uspeak.Data.Models.Study
{
    public class Group : IPersistable, INamed
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid MainTeacherId { get; set; }
        public Teacher MainTeacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public string StartLessonUri { get; set; }
    }
}
