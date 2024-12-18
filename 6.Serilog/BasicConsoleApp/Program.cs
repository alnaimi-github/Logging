using BasicConsoleApp;
using Destructurama;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using SerilogTimings.Extensions;

ILogger logger = new LoggerConfiguration()
    //.WriteTo.Async(x => x.Console(theme:AnsiConsoleTheme.Code), 10)
    .WriteTo.NickSink()
    .Enrich.FromLogContext()
    .Destructure.UsingAttributes()
    .CreateLogger();

Log.Logger = logger;

var payment = new Payment
{
    PaymentId = 1,
    Email = "nick@dometrain.com",
    UserId = Guid.NewGuid(),
    OccuredAt = DateTime.UtcNow
};

logger.Information("Received payment with details {@PaymentData}", payment);

Log.CloseAndFlush();



