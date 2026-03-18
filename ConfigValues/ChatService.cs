using CoreWCF;
using Microsoft.Extensions.Options;

namespace ConfigValues
{
    
    public class ChatService : IChatService
    {
        private ChatServiceConfiguration ChatServiceConfiguration;
        public ChatService(IOptions<ChatServiceConfiguration> featuresConfiguration) 
        {
            ChatServiceConfiguration = featuresConfiguration.Value;
        }
        public string ReceiveMessage()
        {
            if (ChatServiceConfiguration.FeatureEnabled == true)
            {
                return "Message From Server";

            } else
            {
                return "Chat Service NOT enabled !";
            }
        }

        public void SendMessage()
        {
            if(ChatServiceConfiguration.FeatureEnabled == true)
            {
                Console.WriteLine("Sending message..");

            }
        }
    }
}
