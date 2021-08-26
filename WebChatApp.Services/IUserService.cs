using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Services
{
    public interface IUserService
    {
        public User GetUserById(int id);

        public int UpdateUser(int id, User userDto);

        public int AddUser(User userDto);

        public int DeleteUser(int id);

        public User UpdateUserLogin(string login, int userId);

    }
}
