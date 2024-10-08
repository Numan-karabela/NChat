using NChat.Application.Features.Chat.CreateChat;
using NChat.Application.Features.Chat.GetChat;
using NChat.Domain.Entities;

namespace NChat.Application.Abstractions.Repositorys;

public interface IChatRepository
{
    Task<List<GetChatQueryResponse>> GetChatAsync(string userId ,CancellationToken cancellationToken);
    Task CreateMessageAsync(CreateChatCommandRequest message);
}
