using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace _21_WCF_Assignment_SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svcHost = null;
            try
            {
                svcHost = new ServiceHost(typeof(_21_WCF_Library.Service1));
                svcHost.Open();
                Console.WriteLine("\n\nService is Running  at following address");
                Console.WriteLine("\nhttp://localhost:8001/Service1");
                Console.WriteLine("\nnet.tcp://localhost:8002/Service1");
            }
            catch (Exception eX)
            {
                svcHost = null;
                Console.WriteLine("Service can not be started \n\nError Message [" + eX.Message + "]");
            }
            if (svcHost != null)
            {
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
                svcHost.Close();
                svcHost = null;
            }
        }
    }
}
