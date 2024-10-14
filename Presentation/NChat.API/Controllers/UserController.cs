using MediatR;
using Microsoft.AspNetCore.Mvc;
using NChat.Application.Features.Users.CreateUsers;
using NChat.Application.Features.Users.GetUsers;
using NChat.Application.Features.Users.LoginUsers;
using NChat.Persistence.Context;

namespace NChat.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IMediator _mediator,NChatDbContext _nChat ) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateUserAsync(CreateUserCommandRequest request)
    {
      var response= await _mediator.Send(request);
      return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> LoginUserAsync(LoginUserCommandRequest request)
    { 
        var response = await _mediator.Send(request); 
        return Ok(response);
    }
    [HttpGet]
    public async Task<IActionResult> GetUsersAsync()
    { 
        var users= await _mediator.Send(new GetUserQueryRequest());
        return Ok(users);
    }
}
