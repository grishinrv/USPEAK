using System;

namespace Uspeak.Data.Models.Users
{
    public class User : IPersistable, INamed
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public UserType TypeOfUser { get; set; }
    }
}
