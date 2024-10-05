using MediatR;

namespace NChat.Application.Features.Users.CreateUsers;

public class CreateUserCommandRequest:IRequest<string>
{  
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
