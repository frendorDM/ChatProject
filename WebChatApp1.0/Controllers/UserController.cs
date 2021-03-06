using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebChatApp.Data;
using WebChatApp.Models;
using WebChatApp.Models.Entities;
using WebChatApp.ServicesApp;
using WebChatApp1._0.Models.InputModels;
using WebChatApp1._0.Models.OutputModels;

namespace WebChatApp1._0.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService userService) 
        {
            _service = userService;
        }

        // https://localhost:44365/api/user/42
        /// <summary>Get info of user</summary>
        /// <param name="userId">Id of user</param>
        /// <returns>Info of user</returns>
        [ProducesResponseType(typeof(UserOutputDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [HttpGet("{userId}")]
        //[Authorize]
        public ActionResult<UserOutputDto> GetUser(int userId)
        {
            var user = _service.GetUserById(userId);
            if (user == null)
            {
                return NotFound($"User with id {userId} is not found");
            }

            //var outputModel = _mapper.Map<UserOutputModel>(user);
            //
            //return Ok(outputModel);
            return Ok();
        }
        [HttpGet("current")]
        //[Authorize]
        public ActionResult<UserOutputDto> GetCurrentUser()
        {
            var userId = Convert.ToInt32(User.FindFirst("id").Value);
            //var user = _service.GetUserById(userId);
            return Ok();
        }
        // https://localhost:/api/user/register
        /// <summary>user registration</summary>
        /// <param name="inputModel">information about registered user</param>
        /// <returns>rReturn information about added user</returns>
        [ProducesResponseType(typeof(UserOutputDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpPost("register")]
        //[Authorize(Roles = "Администратор, Менеджер")]
        public ActionResult<UserOutputDto> Register([FromBody] UserEntity inputModel)
        {

            //var userDto = _mapper.Map<User>(inputModel);
            var id = _service.AddUser(inputModel);
           // var user = _service.GetUserById(id);
            //var outputModel = _mapper.Map<UserOutputDto>();
            return Ok();

        }

       // [HttpPost("login")]
       // public ActionResult Login([FromBody] UserInputDto inputModel) 
       // {
       // 
       // }
       //
       // [HttpPost("logout")]
       // public ActionResult Logout() 
       // {
       // 
       // }

        // https://localhost:/api/user/42
        /// <summary>Update information about user</summary>
        /// <param name="userId">Id of user</param>
        /// /// <param name="inputModel">Nonupdated info about  user </param>
        /// <returns>Updated info about user</returns>
        [ProducesResponseType(typeof(UserOutputDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [HttpPut("{userId}")]
        [Authorize(Roles = "Администратор, Пользователь")]
        public ActionResult<UserOutputDto> UpdateUserInfo(int userId, [FromBody] UpdateUserInputDto inputModel)
        {

           // var user = _service.GetUserById(userId);
          // if (user == null)
          // {
          //     return NotFound($"User with id {userId} is not found");
          // }
          // if (User.IsInRole("Администратор")
          //     || (User.IsInRole("Пользователь") && user.Roles.Contains(Core.Enums.Role.User)))
          // {
          //     var userDto = _mapper.Map<User>(inputModel);
          //     _service.UpdateUser(userId, userDto);
          //     var outputModel = _mapper.Map<UserOutputDto>(_service.GetUserById(userId));
          //     return Ok(outputModel);
          // }
            ///
                return Forbid("Updated user is not ChatUser");
            //
        }
    }
}
