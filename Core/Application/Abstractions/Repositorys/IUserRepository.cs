using Microsoft.EntityFrameworkCore;
using NChat.Application.Features.Users.GetUsers;
using NChat.Domain.Entities;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Abstractions.Repositorys; 
public interface IUserRepository
{
    Task<List<GetUserQueryResponse>>? GetUsersAsync();
}
