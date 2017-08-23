using System.ServiceModel;

namespace LojaProduto.Services.Spec.Services
{
    [ServiceContract]
    public interface IServiceBase
    {
        [OperationContract]
        string GetServiceVersion();
    }
}