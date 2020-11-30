using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace csy
{
    public partial class TestCardPage : System.Web.UI.Page
    {
        private HtmlTable _htmlTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            //IList<ICard> card = CardUtil.GetCards();
            //if(card.Count>0)
            //{
            //    //phCards.Controls.Add(BuildTable());
            //}

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("CardNew.aspx");
        }

        private HtmlTable BuildTable()
        {
            _htmlTable = new HtmlTable();

            HtmlTableRow row;
            HtmlTableCell cell;
            row = new HtmlTableRow();

            AddCell(row, "学号");
            AddCell(row, "姓名");

            _htmlTable.Rows.Add(row);
            IList<ICard> card = CardUtil.GetCards();
            foreach (ICard stu in card)
            {
                row = new HtmlTableRow();

                AddCell(row, stu.Code);
                AddCell(row, stu.Name);

                //cell = new HtmlTableCell();
                //cell.Controls.Add(new LiteralControl(stu.Code));
                //row.Cells.Add(cell);

                //cell = new HtmlTableCell();
                //cell.Controls.Add(new LiteralControl(stu.Name));
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