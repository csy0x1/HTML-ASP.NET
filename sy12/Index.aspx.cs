using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace csy
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SysHead.InnerText = WebConfigurationManager.AppSettings["SystemName"];

            if(!IsPostBack)
            {

            }
            IStudent stul = new Student()
            {
                StuCode = "12345678",
                StuName = "test"
            };
            setLog(stul.GetInfo());
            setLog("Page_Load");
            log.Value = Application["log"].ToString();
        }

            protected void Page_Init(object sender, EventArgs e)
            {
            setLog("Page_Init");
            }
            protected void Page_InitComplete(object sender, EventArgs e)
            {
                setLog("Page_InitComplete");
            }
            protected void Page_LoadComplete(object sender, EventArgs e)
            {
                setLog("Page_LoadComplete");
            }
            protected void Page_PreInit(object sender, EventArgs e)
            {
                setLog("Page_PreInit");
            }
            protected void Page_PreLoad(object sender, EventArgs e)
            {
                setLog("Page_PreLoad");
            }
            protected void Page_PreRenderComplete(object sender, EventArgs e)
            {
                setLog("Page_PreRenderComplete");
            }
            protected void Page_SaveStateComplete(object sender, EventArgs e)
            {
                setLog("Page_SaveStateComplete");
            }



        private void    setLog(string value)
            {
                LogUtils.setLog(Application, value);
            }
        }
}