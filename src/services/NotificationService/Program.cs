using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();

app.MapHub<NotificationHub>("/hub");

app.Run();

public class NotificationHub : Hub { }