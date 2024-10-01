using AutoMapper;
using NChat.Application.Features.Users.CreateUsers;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Maps
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AppUser,CreateUserCommandRequest>().ReverseMap();
        }
    }
}
