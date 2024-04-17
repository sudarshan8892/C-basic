using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC.Data
{
    public sealed class ConfigurationBlock
    {
        public static string ConnectionString
        {
            get
            {
                if (System.Configuration.ConfigurationManager.ConnectionStrings["hsCoonectionString"] == null)
                {
                    throw new Exception("Connection string not configured");
                }
                return System.Configuration.ConfigurationManager.ConnectionStrings["hsCoonectionString"].ConnectionString;
                //return _ConnectionString;
            }
        }
        public static string MasterConnectionString
        {
            get
            {
                // Get call stack
                StackTrace stackTrace = new StackTrace();

                // Get calling method name
                Console.WriteLine(stackTrace.GetFrame(1).GetMethod().Name);
                //if (HttpContext.Current != null && HttpContext.Current.Session != null && HttpContext.Current.Session[SessionKeys.CompanyConnectionString] != null)
                //{
                //    return HttpContext.Current.Session[SessionKeys.CompanyConnectionString].ToString();
                //}
                if (System.Configuration.ConfigurationManager.ConnectionStrings["hsCoonectionString"] == null)
                {
                    throw new Exception("Connection string not configured");
                }
                return System.Configuration.ConfigurationManager.ConnectionStrings["hsCoonectionString"].ConnectionString;
                //return _ConnectionString;
            }
        }

    }
}