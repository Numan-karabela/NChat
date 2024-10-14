using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NChat.Domain.Entities;
using NChat.Domain.Entities.Identity;

namespace NChat.Persistence.Context;

public class NChatDbContext : IdentityDbContext<AppUser, AppRole, string> 
{ 
    public NChatDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Message> Messages { get; set; } 

} 
