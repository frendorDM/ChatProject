using System;
using WebChatApp.Data;
using WebChatApp.Models;
using WebChatApp.Models.Entities;

namespace WebChatApp.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }
        public int UpdateUser(int id, User userDto)
        {
            userDto.Id = id;
            return _userRepository.UpdateUser(userDto);
        }
        public int AddUser(User userDto)
        {
            //userDto.Password = new SecurityService().GetHash(userDto.Password);
            var result = _userRepository.AddUser(userDto);
           // if (userDto.Roles != null && userDto.Roles.Count > 0)
           // {
           //     foreach (var role in userDto.Roles)
           //     {
           //         _userRepository.AddRoleToUser(result, (int)role);
           //     }
           // }
            return result;
        }
        public int DeleteUser(int id)
        {
            //bool isDeleted = true;
            return _userRepository.DeleteUser(id);
        }
        public User UpdateUserLogin(string login, int userId)
        {
            var userDto = GetUserById(userId);
            userDto.Login = login;
            int updateUserId=_userRepository.UpdateUser(userDto);
            return GetUserById(updateUserId);
            
        }
    }
}
