using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Services
{
    public interface IChatService
    {
        public Chat GetChatById(int id);

        public int AddChat(Chat chatDto);

        public int UpdateChat(Chat chatDto);

        public int DeleteChat(int id);

    }
}
