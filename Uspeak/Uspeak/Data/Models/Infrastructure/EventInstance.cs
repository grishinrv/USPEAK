using System;
using Uspeak.Data.Models.Users;

namespace Uspeak.Data.Models.Infrastructure
{
    public class EventInstance : IPersistable
    {
        public Guid Id { get; set; }
        public Guid ActorId { get; set; }
        public User Actor { get; set; }
        public UserEvent Event { get; set; }
        public Guid SubjectId { get; set; }
        public Entity Subject { get; set; }
        public string Result { get; set; }
        public DateTime Moment { get; set; }
    }
}
