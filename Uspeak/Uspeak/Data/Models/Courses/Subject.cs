using System;

namespace Uspeak.Data.Models.Courses
{
    /// <summary>
    /// Предмет обучения.
    /// </summary>
    public class Subject : IViewable, IPersistable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
