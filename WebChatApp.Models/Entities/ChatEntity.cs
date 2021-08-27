﻿using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models.RelationShip;

namespace WebChatApp.Models.Entities
{
    public class ChatEntity : EntityBaseEntity
    {
        public int UserCreatorId { get; set; }
        public int Type { get; set; }
        

        public List<UserEntity> Users { get; set; } = new List<UserEntity>();
        public List<MessageEntity> Messages { get; set; } = new List<MessageEntity>();
    }
}
