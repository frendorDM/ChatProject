using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebChatApp1._0.Models.InputModels
{
    public class UpdateUserInputDto
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Login { get; set; }
        
    }
}
