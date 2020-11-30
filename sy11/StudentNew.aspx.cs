using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace csy
{
    public partial class StudentNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            IStudent stu = new Student()
            {
                StuCode = ucode.Value,
                StuName = fname.Value
        };
            StuUtil.AddStu(stu);

            Response.Redirect("StudentPage.aspx");
        }
    }
}