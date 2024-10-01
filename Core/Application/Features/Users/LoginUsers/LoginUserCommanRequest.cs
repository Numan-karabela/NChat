using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Users.LoginUsers
{
    public class LoginUserCommanRequest:IRequest<string>
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
