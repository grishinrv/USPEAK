using System;

namespace Uspeak.Data.Models.Study
{
    public class LessonStudentPresence
    {
        public Guid LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public StudentPresence State { get; set; }
        public string Comment { get; set; }
    }
}
