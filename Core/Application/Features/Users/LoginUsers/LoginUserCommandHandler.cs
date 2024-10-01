using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Users.LoginUsers
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommanRequest, string>
    {
        public Task<string> Handle(LoginUserCommanRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
