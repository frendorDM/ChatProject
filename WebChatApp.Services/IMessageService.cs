using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Services
{
    public interface IMessageService
    {
        public int AddMessage(Message messageDto);

        public int DeleteMessage(int id);

    }
}
