using System;
using System.Collections.Generic;
using Uspeak.Models.Tests;

namespace Uspeak.Data.Models.Tests
{
    public class QuestionSettings : IViewable, IPersistable
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Суть вопроса.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Пояснения к заполнению.
        /// </summary>
        public string Description { get; set; }
        public Guid TestForeignKey { get; set; }
        public TestSettings Test { get; set; }
        public QuestionType QuestionType { get; set; }
        public virtual List<AnswerOption> Options { get; set; }
    }
}