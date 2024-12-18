using Microsoft.Extensions.Logging;

#region secret 🤭

using var loggerFactory = LoggerFactory.Create(builder =>
{
#pragma warning disable CA1416
    builder
        .AddConsole()
        .AddEventLog();
#pragma warning restore CA1416
});

ILogger<Program> CreateLogger()
{
    return loggerFactory.CreateLogger<Program>();
}
#endregion

ILogger<Program> logger = CreateLogger();

logger.LogInformation("Hello world!");
