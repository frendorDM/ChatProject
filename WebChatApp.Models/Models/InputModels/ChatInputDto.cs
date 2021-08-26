using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChatApp1._0.Models.InputModels
{
    public class ChatInputDto
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int UserCreatorId { get; set; }
        [Required]
        [Range(1, 3)]
        public int Type { get; set; }
        public List<int> Users { get; set; }
        public List<MessageInputDto> Messages { get; set; }
    }
}
