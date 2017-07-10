using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using WCFServiceLearning.Classes;

namespace WCFServiceLearning
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SampleWCFService : ISampleWCFService
    {
        #region ISampleWCFService Members
        public string SampleMethod(string msg)
        {            
            Console.WriteLine("Called synchronous sample method with \"{0}\"", msg);
            return "The sychronous service greets you: " + msg;
        }

        // This asynchronously implemented operation is never called because there is a synchronous version of the same method.
        public IAsyncResult BeginSampleMethod(string msg, AsyncCallback callback, object asyncState)
        {
            Console.WriteLine("BeginSampleMethod called with: " + msg);

            return new CompletedAsyncResult<string>(msg);
        }

        public string EndSampleMethod(IAsyncResult r)
        {
            CompletedAsyncResult<string> result = r as CompletedAsyncResult<string>;
            Console.WriteLine("EndSampleMethod called with: " + result.Data);
            return result.Data;
        }

        public IAsyncResult BeginServiceAsyncMethod(string msg, AsyncCallback callback, object asyncState)
        {
            var x = 0;
            for (int i = 0; i < 200000000; i++)
            {
                x++;
            }

            Console.WriteLine("BeginServiceAsyncMethod called with: \"{0}\"", msg);

            return new CompletedAsyncResult<string>("BeginServiceAsyncMethod: x = " + x);
        }

        public string EndServiceAsyncMethod(IAsyncResult r)
        {
            CompletedAsyncResult<string> result = r as CompletedAsyncResult<string>;
            Console.WriteLine("EndServiceAsyncMethod called with: \"{0}\"", result.Data);
            return result.Data;
        }
        #endregion
    }
}