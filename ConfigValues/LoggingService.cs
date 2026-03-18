using Microsoft.Extensions.Options;

namespace ConfigValues
{
    public class LoggingService : ILoggingService
    {
        LoggingConfiguration Configuration;

        public LoggingService(IOptionsMonitor<LoggingConfiguration> optionsMonitor)
        {
            Configuration = optionsMonitor.CurrentValue;

            optionsMonitor.OnChange(op =>
            {
                Configuration = op;
            });
        }
        public string Log(string message)
        {
            if(Configuration.EnableLog == true)
            {
                return "Log Pushed";

            } else
            {
                return "Log Not Enabled";
            }
        }
    }
}
