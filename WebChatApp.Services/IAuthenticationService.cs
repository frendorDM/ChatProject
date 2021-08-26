using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;
using WebChatApp.Models.Models;

namespace WebChatApp.Services
{
    public interface IAuthenticationService
    {
        AuthResponse GenerateToken(User user);
        User GetAuthentificatedUser(string login);
    }
}
