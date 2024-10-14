﻿using MChat.SignalR;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using NChat.Application.Abstractions.Repositorys;

namespace NChat.Application.Features.Chat.CreateChat;

public class CreateChatCommandHandler(IChatRepository chat, IHubContext<DenemeHub> hubContext) : IRequestHandler<CreateChatCommandRequest, string>
{
    public async Task<string> Handle(CreateChatCommandRequest request, CancellationToken cancellationToken)
    {
        string connectionId = DenemeHub.Users.First(p => p.Value == request.ReceivedId).Key;

        await hubContext.Clients.Client(connectionId).SendAsync("Messages", request.MessageBody);
        await chat.CreateMessageAsync(request);
        return "Başarılı";
    }
}
