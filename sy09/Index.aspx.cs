﻿using System;
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
        }
    }
}