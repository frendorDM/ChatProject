using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChatApp1._0.Models.OutputModels
{
    public class MessageOutputDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ChatId { get; set; }
        public int UserCreatorId { get; set; }
        public bool isDeleted { get; set; }
    }
}
