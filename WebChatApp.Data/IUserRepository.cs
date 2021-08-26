using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Data
{
    public interface IUserRepository
    {
        public UserEntity GetUserById(int id);

        public int AddUser(UserEntity user);

        public int UpdateUser(UserEntity user);

        public int DeleteUser(int id);

    }
}
