using System;
using WebChatApp.Models.Entities;
using WebChatApp1._0.Models.InputModels;

namespace WebChatApp.ServicesApp
{
    public interface IChatService
    {
        public ChatEntity GetChatById(int id);

        public int AddChat(ChatInputDto chatDto);

        public int UpdateChat(ChatEntity chatDto);

        public int DeleteChat(int id);

    }
}
