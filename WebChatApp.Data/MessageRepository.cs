using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Data
{
    public class MessageRepository : IMessageRepository
    {
        ApplicationContext db;

        public MessageRepository(ApplicationContext context)
        {
            db = context;
        }
        public int AddMessage(MessageEntity messageDto)
        {
            MessageEntity message = new MessageEntity();
            message.Text = messageDto.Text;
            message.ChatId = messageDto.ChatId;
            message.UserCreatorId = messageDto.UserCreatorId;
            message.isDeleted = false;

            db.Messages.Add(message);
            db.SaveChanges();
            return message.Id;
        }
        public int DeleteMessage(int id)
        {
            return id;
        }
        public List<MessageEntity> GetMaterialsByGroupId(int id) 
        {
            return null;
        
        }
    }
}
