using System.Collections.Generic;

namespace WebChatApp.Models.Entities
{
    public class RoleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserEntity> Users { get; set; } //= new List<UserEntity>();
        public List<AccessRuleEntity> AccessRules { get; set; } //= new List<AccessRule>();
    }

}
