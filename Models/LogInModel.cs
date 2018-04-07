using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspCore.Models
{
    public class LogInModel
    {
      public string username{get;set;}
      public string password{get;set;}

      public string name{get;set;}

      public string address{get;set;}

      public string gender{get;set;}
      

    }
}