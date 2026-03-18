using CoreWCF;

namespace ConfigValues
{
    [ServiceContract]
    public interface ILoggingService
    {
        [OperationContract]
        string Log(string message);
    }
}
