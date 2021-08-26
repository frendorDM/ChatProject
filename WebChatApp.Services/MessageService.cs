using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Data;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Services
{
    public class MessageService : IMessageService
    {
        private IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public int AddMessage(Message messageDto)
        {
            return _messageRepository.AddMessage(messageDto);
        
        }
        public int DeleteMessage(int id)
        {
            return _messageRepository.DeleteMessage(id);
        
        }
    }
}
