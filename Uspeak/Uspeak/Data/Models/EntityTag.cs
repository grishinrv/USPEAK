using System;

namespace Uspeak.Data.Models
{
    public class EntityTag
    {
        public Guid EntityId { get; set; }
        public Entity Entity { get; set; }
        public string TagName { get; set; }
        public Tag Tag { get; set; }
    }
}
