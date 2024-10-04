using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace MChat.SignalR
{
    public class DenemeHub(IMediator _mediator) :Hub
    {
        public async Task MessageAsync()
        {
            
        }
        public override async Task OnConnectedAsync()
        {
           var a= Context.ConnectionId;
            
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            
        }
    }
}
