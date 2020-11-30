using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace csy
{
    public partial class StudentPage : System.Web.UI.Page
    {
        private HtmlTable _htmlTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            IList<IStudent> students = StuUtil.GetStudents();
            if(students.Count>0)
            {
            phStudents.Controls.Add(BuildStuTable());
            }

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentNew.aspx");
        }

        private HtmlTable BuildStuTable()
        {
            _htmlTable = new HtmlTable();

            HtmlTableRow row;
            HtmlTableCell cell;
            row = new HtmlTableRow();

            AddCell(row, "学号");
            AddCell(row, "姓名");

            _htmlTable.Rows.Add(row);
            IList<IStudent> students = StuUtil.GetStudents();
            foreach (IStudent stu in students)
            {
                row = new HtmlTableRow();

                AddCell(row, stu.StuCode);
                AddCell(row, stu.StuName);

                //cell = new HtmlTableCell();
                //cell.Controls.Add(new LiteralControl(stu.StuCode));
                //row.Cells.Add(cell);

                //cell = new HtmlTableCell();
                //cell.Controls.Add(new LiteralControl(stu.StuName));
                //row.Cells.Add(cell);

                _htmlTable.Rows.Add(row);
            };

            return _htmlTable;
        }

        private void AddCell(HtmlTableRow row, string value)
        {
            HtmlTableCell cell = new HtmlTableCell();
            cell.Controls.Add(new LiteralControl(value));
            row.Cells.Add(cell);
        }
    }
}