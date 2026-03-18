namespace ConfigValues
{
    public static class TaskServiceCollectionExtensions
    {
        public static IServiceCollection AddOtherServices(this IServiceCollection services,IConfiguration configuration)
        {
             var bEnabled = configuration.GetValue<bool>("FeaturesAvailable:HomePage:ShowLoginPage");
            if(bEnabled)
            {
                services.AddSingleton<IChatService, ChatService>();
                services.AddSingleton<IAuthenticatorService, AuthenticatorService>();
            }
            return services;
        }
    }
}
