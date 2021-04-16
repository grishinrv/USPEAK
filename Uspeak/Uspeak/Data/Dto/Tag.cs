using System;
using Uspeak.Data.Models;

namespace Uspeak.Data.Dto
{
    public class Tag : INamed
    {    
        public Guid Id { get; set; }
        /// <summary>
        /// Имя тэга.
        /// </summary>
        public string Name { get; set; }
        public string CssClass { get; set; }
    }
}
