using System;

namespace Uspeak.Data.Models.Users
{
    public class User : IPersistable, INamed
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public DateTime RegisteredTime { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastTimePasswordChanged { get; set; }
        public UserType TypeOfUser { get; set; }
        /// <summary>
        /// Path to user's files folder.
        /// </summary>
        public string UserFolder { get; set; }
        public Guid PortraitId { get; set; }
        public Image Portrait { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
