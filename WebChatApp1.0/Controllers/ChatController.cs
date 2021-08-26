﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebChatApp.Data;
using WebChatApp.Models.Entities;
using WebChatApp1._0.Models.InputModels;
using WebChatApp1._0.Models.OutputModels;

namespace WebChatApp1._0.Controllers
{
    // https://localhost:44365/api/chat/
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ChatController : ControllerBase
    {
        private IChatRepository _service;
        //private IUserService _userService;

        public ChatController(IChatRepository chatService)
        {
            _service = chatService;
            //_userService = userService;
        }
        /// <summary>
        /// Creates Chat
        /// </summary>
        /// <param name="chat"> is used to get all the information about new chat that is necessary to create it</param>
        /// <returns>Returns the ChatOutputModel</returns>
        // https://localhost:/api/chat/
        [ProducesResponseType(typeof(ChatOutputDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [HttpPost]
        [Authorize]
       //public ActionResult<ChatOutputDto> AddNewChat([FromBody] ChatInputDto chat)
       //{
       //    //var addedChatId = _service.AddChat(_mapper.Map<Chat>(chat)); //в сервисы убрать
       //    //var result = _mapper.Map<ChatOutputDto>(_service.GetChatById(addedChatId)); //в сервисы убрать 
       //    //return Ok(result);
       //}
        // можно сделать 3 контроллера на создание комнат. 3 вида комнат, актоматически заполнять поле Тип Чата.
        // убрать id из ассациативнаых таблиц. Добавить таблицу блок позователей. С датой начала блока и временем блока. Chek is bloked user
        // можно выгнать пользователя по DateTime(MAX)
        /// <summary>
        /// Rename Chat
        /// </summary>
        /// <param name="chat"> is used to rename chat </param>
        /// <returns>Returns the ChatOutputModel</returns>
        /// https://localhost:/api/chat/
        [ProducesResponseType(typeof(ChatOutputDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [HttpPut("id")]
        [Authorize]
        public ActionResult<ChatOutputDto> UpdateChatName(int id, [FromBody] ChatInputDto chat) 
        {

            if (_service.GetChatById(id) == null) 
            {
                return NotFound("Error. Chat not Found");
            }
            //var chatDto = _mapper.Map<Chat>(chat);
            //_service.UpdateChat(chatDto);
            //var result = _mapper.Map<ChatOutputDto>(_service.GetChatById(id));
            return Ok();


        }
    }
}