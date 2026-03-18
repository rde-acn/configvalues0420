using CoreWCF;

namespace ConfigValues
{
    [ServiceContract]
    public interface IAuthenticatorService
    {
        [OperationContract]
        string Authenticate();
    }
}
