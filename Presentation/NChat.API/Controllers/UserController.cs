using MChat.SignalR;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using NChat.Application.Abstractions;
using NChat.Application.Features.Users.CreateUsers;
using NChat.Application.Features.Users.LoginUsers;
using NChat.Domain.Entities;
using NChat.Domain.Entities.Identity;
using NChat.Persistence.Context;

namespace NChat.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IMediator _mediator,NChatDbContext _nChat,IHubContext<DenemeHub> hubContext) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserCommandRequest request)
    {
      var response= await _mediator.Send(request);
      return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> LoginUser(LoginUserCommandRequest request)
    { 
        var response = await _mediator.Send(request); 
        return Ok(response);
    }
}
