using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Data;
using WebChatApp.Models.Entities;
using WebChatApp1._0.Models.InputModels;

namespace WebChatApp.ServicesApp
{
    public class ChatService // : IChatService
    {
        private IMapper _mapper;

        public ChatService(IMapper mapper)
        {
            _mapper = mapper;
        }
        //public ChatEntity GetChatById(int id)
        //{
        //    var dto = _chatRepository.GetChatById(id);
        //    return dto;
        //}
        //public int AddChat(ChatInputDto chatDto)
        //{
        //    var chatModel = _mapper.Map<ChatEntity>(chatDto);
        //    return _chatRepository.AddChat(chatModel);
        //}
        //public int UpdateChat(ChatEntity chatDto)
        //{
        //    return _chatRepository.UpdateChat(chatDto);
        //}
        //public int DeleteChat(int id)
        //{
        //    return _chatRepository.DeleteChat(id);
        //}
    }
}
