
using System.ServiceModel;

namespace MyBasicWCFService
{

    [ServiceContract]
    public interface IMyBasicWCFService
    {
        [OperationContract]
        string GetData(int value);

    }
}
