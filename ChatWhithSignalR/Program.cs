using ChatWhithSignalR;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR(); // подключены сервисы SignalR

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<ChatHub>("/chat"); // ChatHub будет обрабатывать запросы по пути /chat

app.Run();
