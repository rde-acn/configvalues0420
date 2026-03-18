using CoreWCF;

namespace ConfigValues
{
    [ServiceContract]
    public interface IChatService
    {
        [OperationContract]
        void SendMessage();

        [OperationContract]
        string ReceiveMessage();


    }
}
