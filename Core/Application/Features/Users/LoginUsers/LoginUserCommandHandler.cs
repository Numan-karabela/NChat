using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NChat.Application.Abstractions;
using NChat.Domain.Entities.Identity;

namespace NChat.Application.Features.Users.LoginUsers;

public class LoginUserCommandHandler(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager) :
    IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
{

    async Task<LoginUserCommandResponse> IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>.Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
    {

        AppUser appUser = await _userManager.FindByNameAsync(request.UserNameOrEmail);
        if (appUser == null)
            appUser = await _userManager.FindByEmailAsync(request.UserNameOrEmail);
        if (appUser == null)
        {
            return new()
            {
                Message = "Kullanıcı bulunamadı"
            };
        }

        SignInResult result = await _signInManager.CheckPasswordSignInAsync(appUser, request.Password, false);
        if (result.Succeeded)
        {
            return new()
            {
                UserId = appUser.Id,
                UserName = appUser.UserName,
            };

        }
        return new()
        {
            Message = "Kullanıcı ile şifre eşleşmiyor"
        };

    }
} 