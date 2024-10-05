using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Chat.GetChat
{
    public class GetChatQueryRequest:IRequest<List<GetChatQueryResponse>>
    {
        public string userId { get; set; }
        public string toUserId { get; set; } 
    }
}
