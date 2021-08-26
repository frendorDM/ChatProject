using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Data
{
    public class ChatRepository : IChatRepository
    {
        public int AddChat(ChatEntity chatDto) 
        {
            int id=0;
            return id;
        
        }
        public ChatEntity GetChatById(int id) 
        {
            var chat = new ChatEntity();
            return chat;
        }
        public int UpdateChat(ChatEntity chatDto) 
        {
            int id = 0;
            return id;
        }
        public int DeleteChat(int id)
        {
            return id;
        }
    }
}
