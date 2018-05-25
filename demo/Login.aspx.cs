using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo
{
    public partial class Login : System.Web.UI.Page
    {
        private string consql = ConfigurationManager.AppSettings["sql"];
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Session["UesrName"] = UserName.Text.Trim();
            Session["UserKey"] = UserKey.Text.Trim();
            SqlConnection con = new SqlConnection(consql);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(" select * from admin where UserName=@name and UserKey=@key",con);
                com.Parameters.AddWithValue("@name", Session["UesrName"]);
                com.Parameters.AddWithValue("@key", Session["UserKey"]);
                com.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if(ds.Tables[0].Rows.Count>0)
                {
                    //登录成功
                    Response.Redirect("add.aspx");
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

        }
    }
}