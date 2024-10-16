﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using NChat.Application.Features.Chat.CreateChat;
using NChat.Application.Features.Chat.GetChat;

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
    [HttpGet("Create")]
    public async Task<IActionResult> CreateMessageAsync([FromQuery] CreateChatCommandRequest request)
    {
        var message = await mediator.Send(request);
        return Ok(message);
    }
}
