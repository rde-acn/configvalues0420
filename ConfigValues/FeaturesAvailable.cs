namespace ConfigValues
{
    public class FeaturesAvailable
    {
        public HomePage HomePage { get; set; }

        public string LoggingEnabled { get; set; }
    }

    public class HomePage
    {
        public HomePage() { }

        public bool ShowLoginPage { get; set; }

    }
}
