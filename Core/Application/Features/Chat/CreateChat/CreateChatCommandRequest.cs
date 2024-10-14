using MediatR;

namespace NChat.Application.Features.Chat.CreateChat;

public class CreateChatCommandRequest:IRequest<string>
{
    public string SenderId { get; set; }
    public Guid ReceivedId { get; set; }
    public string MessageBody { get; set; }
}
