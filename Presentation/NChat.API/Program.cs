using NChat.Persistence;
using NChat.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddApplicationService(builder.Configuration);




builder.Services.AddCors(opsions => opsions.AddDefaultPolicy(policy =>

    policy.AllowAnyHeader().
    AllowAnyMethod().
    AllowCredentials().SetIsOriginAllowed(x => true)));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
