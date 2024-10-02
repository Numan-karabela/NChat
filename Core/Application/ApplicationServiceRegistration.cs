using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace NChat.Application;
public static class ApplicationServiceRegistration
{
    public static void AddApplicationService(this IServiceCollection services,IConfiguration configuration)
    {
        var assm = Assembly.GetExecutingAssembly();
         //services.AddAutoMapper(assm);
        services.AddMediatR(assm);
        services.AddFluentValidation(p => p.RegisterValidatorsFromAssembly(assm));

    }
}
