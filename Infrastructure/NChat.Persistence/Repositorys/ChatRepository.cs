using Microsoft.EntityFrameworkCore;
using NChat.Application.Abstractions.Repositorys;
using NChat.Application.Features.Chat.GetChat;
using NChat.Domain.Entities;
using NChat.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NChat.Persistence.Repositorys
{
    public class ChatRepository(NChatDbContext nChatDb) : IChatRepository
    {
        public async Task<List<GetChatQueryResponse>>? GetChatAsync(string userId, string toUserId,CancellationToken cancellationToken)
        {
           return await nChatDb
                .Messages
                .Where(p => p.SenderId == userId && p.ReceivedId == toUserId ||
                p.ReceivedId == userId && p.SenderId == toUserId)
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
}
