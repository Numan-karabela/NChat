using Microsoft.EntityFrameworkCore;
using NChat.Application.Abstractions.Repositorys;
using NChat.Application.Features.Users.GetUsers;
using NChat.Domain.Entities;
using NChat.Domain.Entities.Identity;
using NChat.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Persistence.Repositorys;

public class UserRepository(NChatDbContext _nChatDb) : IUserRepository
{
    public async Task<List<GetUserQueryResponse>>? GetUsersAsync()
    { 
       return await _nChatDb.Users
      .OrderBy(p => p.UserName).Select(
           p => new GetUserQueryResponse
           {
               Id = p.Id,
               Name = p.UserName
           })
      .ToListAsync();
    }
}
