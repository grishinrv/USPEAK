using System;
using System.Collections.Generic;

namespace Uspeak.Data.Models.Study
{
    public class Lesson : IPersistable
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public Guid ActualTeacherId { get; set; }
        public Teacher ActualTeacher { get; set; }
        public Guid GroupId { get; set; }
        public Group Group { get; set; }
        public LessonState Status { get; set; }
        public string HomeTask { get; set; }
        public virtual ICollection<LessonStudentPresence> Presences { get; set; }
    }
}
