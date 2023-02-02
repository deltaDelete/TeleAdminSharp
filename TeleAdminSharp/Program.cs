using TeleAdminSharp;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ITelegramBotClient>(provider => {
    var token = provider.GetService<IConfiguration>()?["token"];
    if (!string.IsNullOrWhiteSpace(token)) {
        var client = new TelegramBotClient(token);
        return client;
    }
    throw new Exception("Token was null or empty or whitespace");
});
builder.Services.AddSingleton<Van>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Services.GetService<Van>();

app.Run();