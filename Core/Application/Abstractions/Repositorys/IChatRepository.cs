using NChat.Application.Features.Chat.GetChat;
using NChat.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Abstractions.Repositorys
{
    public interface IChatRepository
    {
        Task<List<GetChatQueryResponse>> GetChatAsync(string userId ,CancellationToken cancellationToken);
    }
}
