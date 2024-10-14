using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.SignalR.Hubs.Chat;

public class ChatHub : Hub
{
    public static Dictionary<string, Guid> Users = new();
    public async Task Connect(Guid userId)
    {
        Users.Add(Context.ConnectionId, userId);
    }
}