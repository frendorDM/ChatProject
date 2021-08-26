using System;
using WebChatApp.Models.Entities;

namespace WebChatApp.ServicesApp
{
    public interface IChatService
    {
        public ChatEntity GetChatById(int id);

        public int AddChat(ChatEntity chatDto);

        public int UpdateChat(ChatEntity chatDto);

        public int DeleteChat(int id);

    }
}
