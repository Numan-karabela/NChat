using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Chat.CreateChat
{
    public class CreateChatCommandHandler : IRequestHandler<CreateChatCommandRequest, CreateChatCommandResponse>
    {
        public Task<CreateChatCommandResponse> Handle(CreateChatCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
