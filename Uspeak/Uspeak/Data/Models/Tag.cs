using System;
using System.Collections.Generic;

namespace Uspeak.Data.Models
{
    /// <summary>
    /// Тэг.
    /// </summary>
    public class Tag : INamed
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Имя тэга.
        /// </summary>
        public string Name { get; set; }
        public TagType TagKind { get; set; }
        public string CssClass { get; set; }
        public virtual ICollection<EntityTag> EntityTags { get; set; }
    }
}
