using Microsoft.EntityFrameworkCore;
using NChat.Application.Abstractions.Repositorys;
using NChat.Application.Features.Chat.CreateChat;
using NChat.Application.Features.Chat.GetChat;
using NChat.Domain.Entities;
using NChat.Persistence.Context;

namespace NChat.Persistence.Repositorys;

public class ChatRepository(NChatDbContext nChatDb) : IChatRepository
{
    public async Task CreateMessageAsync(CreateChatCommandRequest message)
    {
        var sender= await nChatDb.Users.FirstOrDefaultAsync(u => u.Id == message.SenderId);
        await nChatDb.Messages.AddAsync(new()
        {
            Sender= sender,
            MessageBody=message.MessageBody,
            ReceivedId=message.SenderId,
            SenderId=message.SenderId,

        });
       await nChatDb.SaveChangesAsync();

    }

    public async Task<List<GetChatQueryResponse>> GetChatAsync(string userId ,CancellationToken cancellationToken)
    {
       return await nChatDb
            .Messages
            .Where(p => p.SenderId == userId || p.ReceivedId == userId)
            .OrderBy(p => p.DateTime).Select(
       p => new GetChatQueryResponse()
       {
             SenderId = p.SenderId,
             ReceivedId = p.ReceivedId,
             MessageBody = p.MessageBody,
       })
            .ToListAsync(cancellationToken);
    }
}
