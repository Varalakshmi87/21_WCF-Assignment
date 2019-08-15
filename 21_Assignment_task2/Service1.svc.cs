using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _21_Assignment_task2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public static List<JobOpening> lstJobs = new List<JobOpening>() {
            new JobOpening { JobOpeningId =1, JobName=".Net", Role="Manager"},
            new JobOpening { JobOpeningId =2, JobName=".Net", Role="Lead"},
            new JobOpening { JobOpeningId =3, JobName=".Net", Role="Developer"},
            new JobOpening { JobOpeningId =4, JobName="Java", Role="Manager"},
            new JobOpening { JobOpeningId =5, JobName="Java", Role="Lead"},
            new JobOpening { JobOpeningId =6, JobName="Java", Role="Developer"},
            new JobOpening { JobOpeningId =7, JobName="SQL", Role="DBA"},
            new JobOpening { JobOpeningId =8, JobName="SQL", Role="Lead"},
            new JobOpening { JobOpeningId =9, JobName="SQL", Role="Developer"},
            new JobOpening { JobOpeningId =10, JobName="Oracle", Role="Developer"},
            new JobOpening { JobOpeningId =11, JobName="Oracle", Role="Lead"}

        };

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public List<JobOpening> OpeningJobs()
        {
            return lstJobs;
        }

        public List<JobOpening> OpeningJobsByRole(string role)
        {
            return lstJobs.Where(a => a.Role.ToLower() == role.ToLower()).ToList();
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
