using System.Collections.Generic;
using WebChatApp.Models.Entities;
using WebChatApp1._0.Models.InputModels;
using WebChatApp1._0.Models.OutputModels;

namespace WebChatApp.ServicesApp
{
    public interface IMessageService
    {
        public int AddMessage(MessageInputDto messageDto);

        public int DeleteMessage(int id);

        public List<MessageOutputDto> GetMaterialsByGroupId(int id);

    }
}
