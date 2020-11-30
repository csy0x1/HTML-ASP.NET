using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace csy
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            setLog("Application_Start");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            setLog("Session_Start");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            setLog("Application_BeginRequest");
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            setLog("Application_AuthenticateRequest");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            setLog("Application_Error");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            setLog("Session_End");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            setLog("Application_End");
        }

        private void setLog(string value)
        {
            LogUtils.setLog(Application, value);
        }
    }
}