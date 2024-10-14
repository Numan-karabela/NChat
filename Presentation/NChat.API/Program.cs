using NChat.API.Middlewares;
using NChat.Application;
using NChat.Persistence;
using NChat.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddApplicationService(builder.Configuration);
builder.Services.AddSignalR();
builder.Services.AddCorsServiceRefistrations();//police

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
app.UseCors(); 
app.UseHttpsRedirection(); 
app.UseAuthorization();
app.AddMapHub();
app.MapControllers();
app.Run();
