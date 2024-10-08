using MediatR;
using NChat.Application.Abstractions.Repositorys;

namespace NChat.Application.Features.Chat.GetChat;

public class GetChatQueryHandler(IChatRepository chatRepository): IRequestHandler<GetChatQueryRequest,List<GetChatQueryResponse>>
{
    public async Task<List<GetChatQueryResponse>> Handle(GetChatQueryRequest request, CancellationToken cancellationToken)
    {
     return await chatRepository.GetChatAsync(request.userId, cancellationToken);
    }
}
