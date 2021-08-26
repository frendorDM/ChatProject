using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChatApp.Models.Entities;
using WebChatApp1._0.Models.InputModels;
using WebChatApp1._0.Models.OutputModels;

namespace WebChatApp1._0
{
    public class AutomapperConfig : Profile
    {
        private const string _dateFormat = "dd.MM.yyyy";
        private const string _dateFormatWithTime = "dd.MM.yyyy H:mm:ss";
        public AutomapperConfig()
        {
            CreateMap<UserEntity, UserOutputDto>();
            CreateMap<ChatEntity, ChatOutputDto>();
            CreateMap<MessageEntity, MessageOutputDto>();

            CreateMap<UserInputDto, UserEntity>();
            CreateMap<ChatInputDto, ChatEntity>();
            CreateMap<MessageInputDto, MessageEntity>();
        }

    }
}
