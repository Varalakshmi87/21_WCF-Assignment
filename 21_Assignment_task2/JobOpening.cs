using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _21_Assignment_task2
{
    [DataContract]
    public class JobOpening
    {
        [DataMember]
        public int JobOpeningId { get; set; }
        [DataMember]
        public string JobName { get; set; }
        [DataMember]
        public string Role { get; set; }
    }
}