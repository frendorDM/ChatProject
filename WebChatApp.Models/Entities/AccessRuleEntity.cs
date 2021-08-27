using System.Collections.Generic;

namespace WebChatApp.Models.Entities
{
    public class AccessRuleEntity : EntityBaseEntity
    {
        public string Name { get; set; }
        public List<RoleEntity> Roles { get; set; } = new List<RoleEntity>();
        
    }
}
