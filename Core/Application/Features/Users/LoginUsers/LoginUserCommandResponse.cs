using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Users.LoginUsers
{
    public class LoginUserCommandResponse
    {
        public string? Message { get; set; } = string.Empty;
        public string? UserId{ get; set; } = string.Empty;
        public string? UserName { get; set; } = string.Empty;

    }
}
