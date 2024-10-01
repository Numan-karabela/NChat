﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Users.CreateUsers;

public class CreateUserCommandHandler(UserManager<AppUser> userManager,IMapper _mapper) : IRequestHandler<CreateUserCommandRequest, string>
{
    public async Task<string> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
    {
       var user= _mapper.Map<AppUser>(request);
       var  ıdentityResult=await userManager.CreateAsync(user,request.Password);
        
        return ıdentityResult.ToString();
    }
}
