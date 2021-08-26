using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebChatApp.Models.RelationShip;

namespace WebChatApp.Models.Entities
{
    public class UserEntity 
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool isBlocked { get; set; }

        public List<RoleEntity> Roles { get; set; } = new List<RoleEntity>();

        public List<ChatEntity> Chats { get; set; } = new List<ChatEntity>();

        public List<MessageEntity> Messages { get; set; } = new List<MessageEntity>();

    }
}
