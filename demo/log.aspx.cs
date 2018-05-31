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
    public partial class log : System.Web.UI.Page
    {
        static string sql = ConfigurationManager.AppSettings["sql"];
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sql);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("select username=Admin.UserName,log.OperaName,Log.OperaTime,Log.OperaTpye,Log.Remake from Admin join log on Admin.ID=Log.UserID ", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
                repeater1.DataSource = ds;
                repeater1.DataBind();
            }
            finally
            {
                con.Close();
            }
        }
    }
}