using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Data;
using WebChatApp.Models.Entities;

namespace WebChatApp.ServicesApp
{
    public class ChatService : IChatService
    {
        private IChatRepository _chatRepository;

        public ChatService(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }
        public ChatEntity GetChatById(int id)
        {
            var dto = _chatRepository.GetChatById(id);
            return dto;
        }
        public int AddChat(ChatEntity chatDto)
        {
            return _chatRepository.AddChat(chatDto);
        }
        public int UpdateChat(ChatEntity chatDto)
        {
            return _chatRepository.UpdateChat(chatDto);
        }
        public int DeleteChat(int id)
        {
            return _chatRepository.DeleteChat(id);
        }
    }
}
