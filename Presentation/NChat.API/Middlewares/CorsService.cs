namespace NChat.API.Middlewares;

public static class CorsService
{
    public static void AddCorsServiceRefistrations(this IServiceCollection services )
    {
        services.AddCors(opsions =>
             opsions.AddDefaultPolicy
             (policy =>
             policy.AllowAnyHeader().
             AllowAnyMethod().
             AllowCredentials().
             SetIsOriginAllowed(x => true)));

    }

}
