using MediatR;

namespace NChat.Application.Features.Chat.GetChat;

public class GetChatQueryRequest:IRequest<List<GetChatQueryResponse>>
{
    public Guid userId { get; set; } 
}
