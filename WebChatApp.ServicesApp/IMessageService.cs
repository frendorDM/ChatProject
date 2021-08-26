using WebChatApp.Models.Entities;

namespace WebChatApp.ServicesApp
{
    public interface IMessageService
    {
        public int AddMessage(MessageEntity messageDto);

        public int DeleteMessage(int id);

    }
}
