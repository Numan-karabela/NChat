using Microsoft.AspNetCore.SignalR;

namespace NChat.SignalR.Hubs.Chat;

public class ChatHub : Hub
{
    public static Dictionary<string, Guid> Users = new();
    public async Task Connect(Guid userId)
    {
        Users.Add(Context.ConnectionId, userId);
    }
}