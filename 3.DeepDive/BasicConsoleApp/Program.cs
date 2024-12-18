using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

await Host.CreateDefaultBuilder(args)
    .ConfigureLogging(logging =>
        logging
            .AddFilter("System", LogLevel.Debug)
            .AddFilter<ConsoleLoggerProvider>("Microsoft", LogLevel.Information)
            .AddFilter<ConsoleLoggerProvider>("Microsoft.Extensions.Hosting.Internal.Host", LogLevel.Debug))
    .Build()
    .RunAsync();
