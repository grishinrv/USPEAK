using System;

namespace Uspeak.Data.Models
{
    public class Image : IPersistable
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Image path.
        /// </summary>
        public string Path { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
