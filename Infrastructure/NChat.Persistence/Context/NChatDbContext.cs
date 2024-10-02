using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NChat.Application.Abstractions;
using NChat.Domain.Entities;
using NChat.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NChat.Persistence.Context
{
    public class NChatDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
       
        public NChatDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Message> Messages { get; set; }  
    } 
}
