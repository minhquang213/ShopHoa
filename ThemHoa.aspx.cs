using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebHoa.Models;

namespace WebHoa
{
    public partial class ThemHoa : System.Web.UI.Page
    {
        HoaDao daoDao = new HoaDao();

        LoaiDao lDao = new LoaiDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlLoai.DataSource = lDao.docTatCa();
                ddlLoai.DataTextField = "tenLoai";
                ddlLoai.DataValueField = "maLoai";
                ddlLoai.DataBind();
            }
        }

        protected void btxuly_Click(object sender, EventArgs e)
        {
            string tenhoa = txttenhoa.Text;
            int gia = int.Parse(txtgia.Text);
            string hinh = "";
            if(Fhinh.HasFile)
            {
                string path = Server.MapPath("~/Uploads/hinh_san_pham") + "/" + Fhinh.FileName;
                Fhinh.SaveAs(path);
                hinh = Fhinh.FileName;
            }
            else
            {
                hinh = "no_img.jpg";
            }
            int maloai = int.Parse(ddlLoai.SelectedValue);
            DateTime ngaydang = clngaycapnhat.SelectedDate;

            int ketqua = daoDao.Them(tenhoa, gia, hinh, maloai, ngaydang, 0);
            if (ketqua > 0)
            {
                lbThongBao.Text = "Đã thêm 1 sản phẩm(Hoa) thành công";
            }
            else
                lbThongBao.Text = "Thao tác thêm hoa thất bại";
        }
    }
}