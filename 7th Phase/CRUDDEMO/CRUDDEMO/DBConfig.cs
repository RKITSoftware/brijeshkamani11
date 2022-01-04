using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDDEMO
{
    public class DBConfig
    {
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    }
}