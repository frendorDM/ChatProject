using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Data
{
    public class UserRepository : IUserRepository
    {
        ApplicationContext db;

        public UserRepository(ApplicationContext context)
        {
            db = context;
        }
        public UserEntity GetUserById(int id)
        {
            return new UserEntity();
        }
        public int AddUser(UserEntity user)
        {
            UserEntity chatUser = new UserEntity();
            chatUser.FirstName = user.FirstName;
            chatUser.LastName = user.LastName;
            chatUser.Login = user.Login;
            chatUser.Password = user.Password;
            chatUser.BirthDate = DateTime.Now;
            chatUser.isBlocked = false;

            db.Users.Add(chatUser);
            db.SaveChanges();
            return chatUser.Id;// получить id добавленного пользователя
        }
        public int UpdateUser(UserEntity user)
        {

            UserEntity chatUser = new UserEntity();
            chatUser.Id = user.Id;
            chatUser.FirstName = user.FirstName;
            chatUser.LastName = user.LastName;
            chatUser.Login = user.Login;
            chatUser.Password = user.Password;
            chatUser.BirthDate = user.BirthDate;
            chatUser.isBlocked = user.isBlocked;

            db.Users.Add(chatUser);
            db.SaveChanges();
            return chatUser.Id;
        }
        public int DeleteUser(int id)
        {
            UserEntity chatUser = db.Users.Find(id);
            db.Users.Remove(chatUser);
            db.SaveChanges();
            return chatUser.Id;
        }
       //public int UpdateUserLogin(User user, string login)
       //{
       //
       //    User chatUser = new User();
       //    chatUser.Id = user.Id;
       //    chatUser.FirstName = user.FirstName;
       //    chatUser.LastName = user.LastName;
       //    chatUser.Login = user.Login;
       //    chatUser.Password = user.Password;
       //    chatUser.BirthDate = user.BirthDate;
       //    chatUser.isBlocked = user.isBlocked;
       //
       //    db.Users.Add(chatUser);
       //    db.SaveChanges();
       //    return chatUser.Id;
       //}
    }
}
