using MediatR;
using Microsoft.AspNetCore.Identity;
using NChat.Domain.Entities.Identity;

namespace NChat.Application.Features.Users.CreateUsers;

public class CreateUserCommandHandler(UserManager<AppUser> _userManager) : IRequestHandler<CreateUserCommandRequest,string>
{
    public async Task<string> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
    {
       var  ıdentityResult= await _userManager.CreateAsync(new()
       {
           Id = Guid.NewGuid().ToString(),
           
           UserName = request.UserName,  
           Email = request.Email,

       }, request.Password);

        return ıdentityResult.ToString();
    }
}
