using Serilog;
using Serilog.Formatting.Json;
namespace SimpleAPI.Services
{
    public static class AppExtension
    {
        public static void SerilogConfig(this IHostBuilder host)
        {
            host.UseSerilog(configureLogger:(ContextBoundObject,loggerConfig)=>
            {
                loggerConfig.WriteTo.Console();
                loggerConfig.WriteTo.File(new JsonFormatter(),path:"Logs/applogs-.txt",rollingInterval:RollingInterval.Day);
            });
        }
    }
}