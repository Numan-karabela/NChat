using MediatR;
using NChat.Application.Abstractions.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Chat.CreateChat
{
    public class CreateChatCommandHandler(IChatRepository chat): IRequestHandler<CreateChatCommandRequest, string>
    {
        public async Task<string> Handle(CreateChatCommandRequest request, CancellationToken cancellationToken)
        {

           await chat.CreateMessageAsync(request);
            return "Başarılı";
        }
    }
}
