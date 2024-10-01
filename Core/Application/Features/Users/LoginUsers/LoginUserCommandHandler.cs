using MediatR;
using Microsoft.AspNetCore.Identity;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Users.LoginUsers;

public class LoginUserCommandHandler(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager):
    IRequestHandler<LoginUserCommanRequest, string>
{
   
    public async Task<string> Handle(LoginUserCommanRequest request, CancellationToken cancellationToken)
    {
        AppUser appUser = await _userManager.FindByNameAsync(request.UserNameOrEmail);
        if (appUser == null)
            appUser = await _userManager.FindByEmailAsync(request.UserNameOrEmail);
        if (appUser == null)
        {
            return new("Kullanıcı Bulunamadı");
        }
        
        SignInResult result = await _signInManager.CheckPasswordSignInAsync(appUser, request.Password, false);
        if (result.Succeeded)
        {
            return result.Succeeded.ToString();

        }
        return "şifre eşleşmiyor";
      
         
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
    }
}
