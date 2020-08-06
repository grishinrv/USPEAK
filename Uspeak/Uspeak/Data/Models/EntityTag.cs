using System;

namespace Uspeak.Data.Models
{
    public class EntityTag
    {
        public Guid EntityId { get; set; }
        public Entity Entity { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
