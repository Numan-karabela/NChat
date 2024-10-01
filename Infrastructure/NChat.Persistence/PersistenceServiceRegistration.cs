using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NChat.Application.Abstractions;
using NChat.Domain.Entities.Identity;
using NChat.Persistence.Context;

namespace NChat.Persistence;

public static class PersistenceServiceRegistration
{
    public static void AddPersistenceService(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<NChatDbContext>(options => 
        options.UseSqlServer(configuration.GetConnectionString("NChatSql")));
        services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<NChatDbContext>();
        services.AddScoped<INChatDbContext, NChatDbContext>();

    }
}
