using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Uspeak.Data.Models
{
    /// <summary>
    /// Тэг.
    /// </summary>
    public class Tag : INamed
    {
        /// <summary>
        /// Имя тэга. Ключ.
        /// </summary>
        public string Name { get; set; }
        public virtual ICollection<EntityTag> EntityTags { get; set; }
        public TagType TagKind { get; set; }
    }
}
