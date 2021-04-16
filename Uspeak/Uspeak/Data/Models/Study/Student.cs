using System;
using System.Collections.Generic;
using Uspeak.Data.Models.Users;

namespace Uspeak.Data.Models.Study
{
    public class Student : IPersistable
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
