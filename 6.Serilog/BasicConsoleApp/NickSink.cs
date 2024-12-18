using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog.Events;

namespace BasicConsoleApp;

public class NickSink : ILogEventSink
{
    private readonly IFormatProvider? _formatProvider;

    public NickSink(IFormatProvider? formatProvider)
    {
        _formatProvider = formatProvider;
    }
    
    public NickSink() : this(null)
    {
    }

    public void Emit(LogEvent logEvent)
    {
        var message = logEvent.RenderMessage(_formatProvider);
        Console.WriteLine($"{DateTime.UtcNow} - {message}");
    }
}


public static class NickSinkExtensions
{
    public static LoggerConfiguration NickSink(
        this LoggerSinkConfiguration sinkConfiguration,
        IFormatProvider? formatProvider = null)
    {
        return sinkConfiguration.Sink(new NickSink());
    }
}
