using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;
using WebChatApp1._0.Models.OutputModels;

namespace WebChatApp.Data
{
    public interface IMessageRepository
    {
        public int AddMessage(MessageEntity messageDto);

        public int DeleteMessage(int id);
        public List<MessageEntity> GetMaterialsByGroupId(int id);

    }
}
