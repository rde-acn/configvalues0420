namespace ConfigValues
{
    public class FeaturesConfiguration
    {
        public FeaturesConfiguration() { }

        public HomePage HomePage { get; set; }

        public string LoggingEnabled { get; set; }

    }


    public class ChatServiceConfiguration
    {
        public ChatServiceConfiguration() { }

        public bool FeatureEnabled { get; set; }
    }

    public class AuthServiceConfiguration
    {
        public AuthServiceConfiguration() { }

        public bool EnableLogin { get; set; }
    }

    public class LoggingConfiguration
    {
        public LoggingConfiguration() { }

        public bool EnableLog { get; set; }
    }
}
