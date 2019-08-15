using _21_WCf_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21_WCf_Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.result = Convert.ToString(TempData["Result"]);
            return View();
        }

        public ActionResult About()
        {
            HttpServiceReference.Service1Client Client = new HttpServiceReference.Service1Client("BasicHttpBinding_IService1");
            ViewBag.SayHello = Client.SayHello("Varalakshmi");
            ViewBag.TodayProgram = Client.TodayProgram("Varalakshmi");

            return View();
        }

        public ActionResult Contact()
        {
            HttpServiceReference.Service1Client Client = new HttpServiceReference.Service1Client("NetTcpBinding_IService1");
            ViewBag.SayHello = Client.SayHello("Varalakshmi");
            ViewBag.TodayProgram = Client.TodayProgram("Varalakshmi");

            return View();
        }

        public ActionResult JobOpening()
        {
            Task2ServiceReference.Service1Client Client = new Task2ServiceReference.Service1Client("BasicHttpBinding_IService12");
            List<JobModel> model = new List<Models.JobModel>();
            model = Client.OpeningJobs().Select(a => new JobModel { JobName = a.JobName, JobOpeningId = a.JobOpeningId, Role = a.Role }).ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult JobOpening(FormCollection collection)
        {
            Task2ServiceReference.Service1Client Client = new Task2ServiceReference.Service1Client("BasicHttpBinding_IService12");
            List<JobModel> model = new List<Models.JobModel>();
            model = Client.OpeningJobsByRole(collection["Role"].ToString()).Select(a => new JobModel { JobName = a.JobName, JobOpeningId = a.JobOpeningId, Role = a.Role }).ToList();
            return View("JobOpening", model);
        }

        [HttpPost]
        public ActionResult Calculate(FormCollection col)
        {
            int num1 = Convert.ToInt32(col["input1"]);
            int num2 = Convert.ToInt32(col["input2"]);
            string action = Convert.ToString(col["action"]);
            Task2ServiceReference.Service1Client Client = new Task2ServiceReference.Service1Client("BasicHttpBinding_IService12");

            switch (action)
            {
                case "Add":
                    TempData["Result"] = Client.Add(num1, num2);
                    break;
                case "Subtract":
                    TempData["Result"] = Client.Subtract(num1, num2);
                    break;
                case "Multiply":
                    TempData["Result"] = Client.Multiply(num1, num2);
                    break;
                case "Divide":
                    TempData["Result"] = Client.Divide(num1, num2);
                    break;
            }
            
            return RedirectToAction("Index");
        }
    }
}