using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Data
{
    public interface IMessageRepository
    {
        public int AddMessage(MessageEntity messageDto);

        public int DeleteMessage(int id);

    }
}
