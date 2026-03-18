namespace ConfigValues
{
    public class TaskService : ITaskService
    {
        private readonly IConfiguration _configuration;

        public FeaturesAvailable fAvailable { get; set; }
        public TaskService(IConfiguration configuration)
        { 
            _configuration = configuration;
            InstantiateFeaturesAvailable();
        }

        private void InstantiateFeaturesAvailable()
        {
            FeaturesAvailable featuresAvailable = new FeaturesAvailable();
            _configuration.Bind("FeaturesAvailable", featuresAvailable);
            fAvailable = featuresAvailable;
        }

        public string? GetTask()
        {
            // return _configuration?.GetValue<string>("TaskDetails:TodaysTask");

            return fAvailable.HomePage.ShowLoginPage.ToString();
        }

        public void SetTask(string Task)
        {
            Console.WriteLine("Task Assigned");

        }

        public bool ShowLoginPage()
        {
           //var show = _configuration.GetValue<bool>("FeaturesAvailable:HomePage:ShowLoginPage");
           // return show;

            var configurationValue = _configuration.GetSection("FeaturesAvailable:HomePage");
            var show = configurationValue.GetValue<bool>("ShowLoginPage");
            return show;
        }

        public void TaskBoard()
        {
            throw new NotImplementedException();
        }
    }
}
