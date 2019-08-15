using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _21_Assignment_task2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<JobOpening> OpeningJobs();

        [OperationContract]
        List<JobOpening> OpeningJobsByRole(string role);

        [OperationContract]
        int Add(int a, int b);
        [OperationContract]
        int Subtract(int a, int b);
        [OperationContract]
        int Multiply(int a, int b);
        [OperationContract]
        int Divide(int a, int b);
        // TODO: Add your service operations here
    }


}
