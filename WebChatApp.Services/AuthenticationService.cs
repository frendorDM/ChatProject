using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;
using WebChatApp.Models.Models;

namespace WebChatApp.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthResponse GenerateToken(User user) 
        {
            return new AuthResponse();
        
        }
        
        public User GetAuthentificatedUser(string login) 
        {
            return new User();
        
        }
    }
}
