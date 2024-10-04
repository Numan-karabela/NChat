using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NChat.Application.Abstractions;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Users.LoginUsers;

public class LoginUserCommandHandler(INChatDbContext nChatDb, UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager) :
    IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
{



    //if (result.Succeeded)
    //{
    //    TokenResponse token = _tokenHandler.CreateAccessToken(15);
    //    return new()
    //    {
    //        message = "Giriş başarılı",
    //        Token = token
    //    };
    //}
    //else
    //    return new() { message = "şifre eşleşmiyor" }; 
    async Task<LoginUserCommandResponse> IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>.Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
    {
        
            AppUser appUser = await _userManager.FindByNameAsync(request.UserNameOrEmail);
            if (appUser == null)
                appUser = await _userManager.FindByEmailAsync(request.UserNameOrEmail);
            if (appUser == null)
            {
                return new()
                {

                };
            }

            SignInResult result = await _signInManager.CheckPasswordSignInAsync(appUser, request.Password, false);
            if (result.Succeeded)
            {
                var user = await nChatDb.AppUsers.FirstOrDefaultAsync(p => p.UserName == request.UserNameOrEmail || p.Email == request.UserNameOrEmail);
                return new()
                {
                    Id = user.Id,
                    Name = user.UserName
                };

            }
            return new()
            {

            };

        
    }
}
