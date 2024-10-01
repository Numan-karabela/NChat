using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NChat.Application.Features.Users.CreateUsers;
using NChat.Application.Features.Users.LoginUsers;

namespace NChat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest request)
        {
          var response= await _mediator.Send(request);
          return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> LoginUser(LoginUserCommanRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
