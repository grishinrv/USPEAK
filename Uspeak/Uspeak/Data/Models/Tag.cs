using System;
using System.ComponentModel.DataAnnotations;

namespace Uspeak.Data.Models
{
    /// <summary>
    /// Тэг.
    /// </summary>
    public class Tag : INamed
    {
        /// <summary>
        /// Имя тэга. Часть составного ключа.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Id Родительской сущности. Часть составного ключа.
        /// </summary>
        public Guid EnityId { get; set; }
        public Enitity Enitity { get; set; }
        public TagType TagKind { get; set; }
    }
}
