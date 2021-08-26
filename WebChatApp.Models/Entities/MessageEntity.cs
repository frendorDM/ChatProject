using System;
using System.Collections.Generic;
using System.Text;

namespace WebChatApp.Models.Entities
{
    public class MessageEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ChatId { get; set; }
        public int UserCreatorId { get; set; }
        public bool isDeleted { get; set; }
        public UserEntity User { get; set; }
        public ChatEntity Chat { get; set; }
    }
}
