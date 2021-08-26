using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Data
{
    public class ChatRepository : IChatRepository
    {
        ApplicationContext db;

        public ChatRepository(ApplicationContext context)
        {
            db = context;
        }
        public int AddChat(ChatEntity chat) 
        {
            ChatEntity newChat = new ChatEntity();
            newChat.Type= chat.Type;
            newChat.UserCreatorId = chat.UserCreatorId;

            db.Chats.Add(newChat);
            db.SaveChanges();
            return newChat.Id;

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
