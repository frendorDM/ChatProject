using Microsoft.EntityFrameworkCore;
using WebChatApp.Models.Entities;

namespace WebChatApp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; } 
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<AccessRuleEntity> AccessRules { get; set; }
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        // public DbSet<RoleAccessRule> RoleAccessRules { get; set; }
        // public DbSet<UserChat> UserChats { get; set; }
        // public DbSet<UserRole> UserRoles { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .HasMany(x=>x.Roles)
        //        .
        //        
        //        
        //    
        //}

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();

        }
    }
}
