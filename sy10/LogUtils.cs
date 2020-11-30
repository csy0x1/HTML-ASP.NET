using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csy
{
    public class LogUtils
    {
        public static void setLog(HttpApplicationState application,string value)
        {
            if (application.AllKeys.Contains("log"))
            {
                application["log"] += value + "\n";
            }
            else
            {
                application["log"] += value + "\n";

            }
        }
    }
}