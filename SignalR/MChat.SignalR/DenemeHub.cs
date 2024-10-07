using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace MChat.SignalR;

public class DenemeHub:Hub
{
    public static Dictionary<string, Guid> Users = new();
    public async Task Connect(Guid userId)
    {
        Users.Add(Context.ConnectionId, userId);  
    }

}
