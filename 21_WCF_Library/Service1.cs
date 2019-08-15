using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _21_WCF_Library
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        public string SayHello(string Name)
        {
            string Wish = "";
            int currentHr = DateTime.Now.Hour;
            if (currentHr <= 11)
                Wish = "Good Morning " + Name;
            else if (currentHr > 11 && currentHr <= 3)
                Wish = "Good Noon " + Name;
            else if (currentHr > 15 && currentHr <= 19)
                Wish = "Good evening " + Name;
            else
                Wish = "Good Night " + Name;

            return Wish;
        }

        public string TodayProgram(string Name)
        {
            string Wish = "";
            DayOfWeek CurrentDay = DateTime.Now.DayOfWeek;
            if (CurrentDay == DayOfWeek.Saturday || CurrentDay == DayOfWeek.Sunday)
                Wish = "Happy weekend " + Name;
            else
                Wish = "Enjoy Working day " + Name;
            return Wish;
        }
    }
}
