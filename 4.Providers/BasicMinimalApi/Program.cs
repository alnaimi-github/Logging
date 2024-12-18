using BasicMinimalApi;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    builder.Logging.ClearProviders();
    //builder.Logging.AddConsole();
    builder.Logging.AddProvider(new NickLoggerProvider());
}
else
{
    builder.Logging.ClearProviders();
    builder.Logging.AddApplicationInsights(
        configureTelemetryConfiguration: teleConfig =>
            teleConfig.ConnectionString = "InstrumentationKey=3f0c4b53-89b6-4b84-811c-5659284c9071;IngestionEndpoint=https://northeurope-2.in.applicationinsights.azure.com/;LiveEndpoint=https://northeurope.livediagnostics.monitor.azure.com/",
        configureApplicationInsightsLoggerOptions: _ => { });
}

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
