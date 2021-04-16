using Microsoft.AspNetCore.Identity;
using System;

namespace Uspeak.Data.Models.Users
{
    public class User : IdentityUser<Guid>, IPersistable, INamed
    {
        /// <summary>
        /// Полное имя пользователя (ФИО).
        /// </summary>
        public string Name { get; set; }
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
    }
}
