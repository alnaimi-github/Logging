using BasicConsoleApp;
using Microsoft.Extensions.Logging;

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .SetMinimumLevel(LogLevel.Information)
        .AddConsole();
    //.AddConsole();
});

ILogger logger = loggerFactory.CreateLogger<Program>();

var name = "Nick";
var age = 30;

//logger.LogInformation("{Name} just turned: {Age}", name, age);
logger.LogInformation(LogEvents.UserBirthday, "{Name} just turned: {Age}", name, age);







