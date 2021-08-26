using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChatApp1._0.Models.OutputModels
{
    public class UserOutputDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Login { get; set; }
        public List<int> Roles { get; set; }
    }
}
