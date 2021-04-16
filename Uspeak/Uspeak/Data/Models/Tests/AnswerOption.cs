using System;

namespace Uspeak.Data.Models.Tests
{
    public class AnswerOption : IPersistable
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string RightAnswer { get; set; }
        public decimal WinPoints { get; set; } // todo specify decimal type
        public decimal LoosePoints { get; set; }// todo specify decimal type
        public Guid QuestionForeignKey { get; set; }
        public QuestionSettings Question { get; set; }
    }
}