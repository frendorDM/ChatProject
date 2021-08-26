using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChatApp1._0.Models.InputModels
{
    public class MessageInputDto
    {
        [Required]
        [StringLength(1000)]
        public string Text { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int ChatId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int UserCreatorId { get; set; }
        [Required]
        public bool isDeleted { get; set; }

    }
}
