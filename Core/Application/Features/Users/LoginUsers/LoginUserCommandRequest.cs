using MediatR;

namespace NChat.Application.Features.Users.LoginUsers;

public class LoginUserCommandRequest:IRequest<LoginUserCommandResponse>
{
    public string UserNameOrEmail { get; set; }
    public string Password { get; set; }
}
