using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NChat.Application.Features.Chat.GetChat;
using NChat.Persistence.Context;
using System;

namespace NChat.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChatController(IMediator mediator) : ControllerBase
{
    [HttpGet("Get")]
    public async Task<IActionResult> GetChatsAsync([FromQuery]GetChatQueryRequest request)
    {
       var message =await mediator.Send(request);
        return Ok(message);
    }
    [HttpGet("Get")]
    public async Task<IActionResult> GetChatsAsync([FromQuery] GetChatQueryRequest request)
    {
        var message = await mediator.Send(request);
        return Ok(message);
    }
}
