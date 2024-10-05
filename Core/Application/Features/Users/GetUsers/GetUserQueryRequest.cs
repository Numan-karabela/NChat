using MediatR;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Features.Users.GetUsers
{
    public class GetUserQueryRequest:IRequest<List<GetUserQueryResponse>>
    {
    }
}
