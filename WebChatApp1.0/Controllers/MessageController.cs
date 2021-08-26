using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebChatApp.Data;
using WebChatApp.Models.Entities;
using WebChatApp1._0.Models.InputModels;
using WebChatApp1._0.Models.OutputModels;

namespace WebChatApp1._0.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class MessageController : ControllerBase
    {
        private IChatRepository _service;


        public MessageController(IChatRepository messageService, IMapper mapper) 
        {
            _service = messageService;       
        }

        /// <summary>
        /// Create new message
        /// </summary>
        /// <param name="messageInputModel">Model object of message to be created</param>
        /// <returns>Return OutputModel of created attachment</returns>
        // https://localhost:/api/chat/message
        [ProducesResponseType(typeof(MessageOutputDto), StatusCodes.Status200OK)]
        [HttpPost]
        [Authorize]
        public ActionResult<MessageOutputDto> AddMessage([FromBody] MessageInputDto messageInputModel)
        {

            //var messageDto = _mapper.Map<Message>(messageInputModel);
            //var newEntityId = _service.AddMessage(messageDto);
            //var newMessageDto = _service.GetMessageById(newEntityId);
            //var result = _mapper.Map<MessageOutputDto>(newMessageDto);
            //return Ok(result);
            return Ok();
        }

        /// <summary>
        /// Delete Message(by Id)
        /// </summary>
        /// <param name="id">Id of the message to be deleted</param>
        /// <returns>Return deleted MessageOutputModel</returns>
        // https://localhost:/api/chat/../message/
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{id}")]
        [Authorize(Roles = "Администратор, Модератор")]
        public ActionResult DeleteMessage(int id)
        {
            //if (_service.GetMessageById(id) is null)
            //    return NotFound($"Message {id} not found");
            //_service.DeleteMessageById(id);
            return NoContent();
        }
    }
}
