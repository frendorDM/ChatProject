using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebChatApp.Data;
using WebChatApp.ServicesApp;

namespace WebChatApp1._0.Config
{
    public static class ServicesConfig
    {
        public static void RegistrateServicesConfig(this IServiceCollection services)
        {
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IMessageService, MessageService>();
            //services.AddScoped<IChatService, ChatService>();
            ////services.AddScoped<IAuthenticationService, AuthenticationService>();


            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IMessageRepository, MessageRepository>();
            //services.AddScoped<IChatRepository, ChatRepository>();

        }
    }
}
