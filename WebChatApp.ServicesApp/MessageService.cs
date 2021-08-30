using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebChatApp.Data;
using WebChatApp.Models.Entities;
using WebChatApp1._0.Models.InputModels;
using WebChatApp1._0.Models.OutputModels;

namespace WebChatApp.ServicesApp
{
    public class MessageService //: IMessageService
    {
        //private IMessageRepository _messageRepository;
        //private IMapper _mapper;

        //public MessageService(IMessageRepository messageRepository, IMapper mapper)
        //{
        //    _messageRepository = messageRepository;
        //    _mapper = mapper;
        //}
        //public int AddMessage(MessageInputDto messageInputDto)
        //{
        //    var messageDto = _mapper.Map<MessageEntity>(messageInputDto);
        //    return _messageRepository.AddMessage(messageDto);

        //}
        //public int DeleteMessage(int id)
        //{
        //    return _messageRepository.DeleteMessage(id);

        //}
        //public List<MessageOutputDto> GetMaterialsByGroupId(int id) 
        //{

        //    var messages = _messageRepository.GetMaterialsByGroupId(id);
        //    return null; //_mapper.Map<List<MaterialOutputModel>>(messages);
        //}
    }
}
