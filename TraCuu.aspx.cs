using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebHoa.Models;

namespace WebHoa
{
    public partial class TraCuu : System.Web.UI.Page
    {
        HoaDao HoaDao = new HoaDao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btTraCuu_Click(object sender, EventArgs e)
        {
            int tu = int.Parse(txtGiaTu.Text);
            int den = int.Parse(txtGiaDen.Text);
            rptHoa.DataSource = HoaDao.TraCuuTheoGia(tu, den);
            rptHoa.DataBind();
        }
    }
}