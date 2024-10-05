using NChat.Domain.Entities;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Chat.GetChat
{
    public class GetChatQueryResponse
    {
        public string SenderId { get; set; } 
        public string MessageBody { get; set; }
        public string ReceivedId { get; set; }
    }
}
