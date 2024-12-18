var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", (ILogger<Program> logger) =>
{
    return "Hello World!";
});

app.Run();
