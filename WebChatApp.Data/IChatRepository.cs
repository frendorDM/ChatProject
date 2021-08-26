using WebChatApp.Models.Entities;

namespace WebChatApp.Data
{
    public interface IChatRepository
    {
        public int AddChat(ChatEntity chatDto);

        public int UpdateChat(ChatEntity chatDto);

        public int DeleteChat(int id);

        public ChatEntity GetChatById(int id);

    }
}
