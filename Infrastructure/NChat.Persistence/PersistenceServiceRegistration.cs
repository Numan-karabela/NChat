using Microsoft.AspNetCore.Identity;
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
        services.AddScoped<INChatDbContext, NChatDbContext>();

        services.AddIdentity<AppUser, AppRole>(options =>
        {
            options.Password.RequiredLength = 3;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;


        }).AddEntityFrameworkStores<NChatDbContext>()
          .AddDefaultTokenProviders();

    }
}
