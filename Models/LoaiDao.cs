using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebHoa.Models
{
    public class LoaiDao
    {
        public DataTable docTatCa()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HoaTuoiDBConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Loai", conn);
            SqlDataAdapter dat = new SqlDataAdapter(cmd);
            dat.Fill(dt);
            return dt;
        }
        public int Them(string tenhoa, int gia, string hinh, int maloai, DateTime ngaydang, int soluongxem)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HoaTuoiDBConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Insert into hoa(tenhoa,gia,hinh,maloai,ngaydang,soluotxem)" +
                                             ("value (@tenhoa,@gia,@hinh,@maloai,@ngaydang,@soluotxem"), conn);
            cmd.Parameters.AddWithValue("@tenhoa", tenhoa);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@hinh", hinh);
            cmd.Parameters.AddWithValue("@maloai", maloai);
            cmd.Parameters.AddWithValue("@ngaydang", ngaydang);
            cmd.Parameters.AddWithValue("@soluotxem", soluongxem);

            return cmd.ExecuteNonQuery();
        }
    }

}


