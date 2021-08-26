using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Data
{
    public class MessageRepository : IMessageRepository
    {
        public int AddMessage(MessageEntity messageDto)
        {
            int id = 0;
            return id;

        }
        public int DeleteMessage(int id)
        {
            return id;

        }

    }
}
