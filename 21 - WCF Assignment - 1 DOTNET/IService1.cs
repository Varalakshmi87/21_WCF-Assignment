﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _21___WCF_Assignment___1_DOTNET
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string SayHello(string Name);

        [OperationContract]
        string TodayProgram(string Name);

        // TODO: Add your service operations here
    }


   
}
