using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Chat.CreateChat
{
    public class CreateChatCommandRequest:IRequest<string>
    {
        public string SenderId { get; set; }
        public Guid ReceivedId { get; set; }
        public string MessageBody { get; set; }
    }
}
