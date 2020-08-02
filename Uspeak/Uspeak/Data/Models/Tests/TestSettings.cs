using System;
using System.Collections.Generic;
using Uspeak.Data.Models.Courses;
using Uspeak.Data.Models.Users;

namespace Uspeak.Data.Models.Tests
{
    public class TestSettings : IViewable, IPersistable
    {
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool RandomizeQuestionOrder { get; set; }
        public bool ShowRightChosesAmount { get; set; }
        public Guid CourseForeignKey { get; set; }
        public Course Course { get; set; }
        public Guid AuthorForeignKey { get; set; }
        public User Author { get; set; }
        public List<QuestionSettings> Questions { get; set; }
    }
}
