using Microsoft.EntityFrameworkCore;
using NChat.Domain.Entities;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Application.Abstractions
{
   public interface INChatDbContext
    {
        public DbSet<Message> Messages { get; set; } 

    }
}
