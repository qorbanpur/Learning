using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceLearning
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContractAttribute()]
    public interface ISampleWCFService
    {
        [OperationContractAttribute]
        string SampleMethod(string msg);

        [OperationContractAttribute(AsyncPattern = true)]
        IAsyncResult BeginSampleMethod(string msg, AsyncCallback callback, object asyncState);

        //Note: There is no OperationContractAttribute for the end method.
        string EndSampleMethod(IAsyncResult result);

        [OperationContractAttribute(AsyncPattern = true)]
        IAsyncResult BeginServiceAsyncMethod(string msg, AsyncCallback callback, object asyncState);

        // Note: There is no OperationContractAttribute for the end method.
        string EndServiceAsyncMethod(IAsyncResult result);
    }
}