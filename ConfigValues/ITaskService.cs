using CoreWCF;

namespace ConfigValues
{
    [ServiceContract]
    public interface ITaskService
    {
        [OperationContract]
        void TaskBoard();

        [OperationContract]
        string GetTask();

        [OperationContract]
        void SetTask(string Task);

        [OperationContract]
        bool ShowLoginPage();
    }
}
