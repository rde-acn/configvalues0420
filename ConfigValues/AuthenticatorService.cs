using Microsoft.Extensions.Options;
using static System.Net.Mime.MediaTypeNames;

namespace ConfigValues
{
    public class AuthenticatorService : IAuthenticatorService
    {
        AuthServiceConfiguration configuration;

        IServiceProvider _serviceProvider;
        public AuthenticatorService( IServiceProvider serviceProvider) 
        {
            //configuration = optionsSnapshot.Value;
            _serviceProvider = serviceProvider;
        }
        public string Authenticate()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var scopedProvider = scope.ServiceProvider;
                var test = scopedProvider.GetRequiredService<IOptionsSnapshot<AuthServiceConfiguration>>();

                if (test.Value.EnableLogin == true)
                {
                    return "Authenticated Successfuly !";
                }
                else
                {
                    return "Login Not Enabled !";
                }

                //...
            }
           

        }
    }
}
