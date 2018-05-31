using System;
using System.Collections;
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
    public partial class choose : System.Web.UI.Page
    {
       static  string sql = ConfigurationManager.AppSettings["sql"];
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string a = Request["x"];
                represent();
            }
        }

        private void represent()
        {
            SqlConnection con = new SqlConnection(sql);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("select username,role,telephone,Login from admin ", con);
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

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
          for(int i =0;i<repeater1.Items.Count;i++)
            {
                RepeaterItem item = repeater1.Items[i];
                Label l;
                
               CheckBox c=  item.FindControl("checkbox") as CheckBox;
                if(c.Checked)
                {
                    l = item.FindControl("lbName") as Label;
                    
                    SqlConnection con = new SqlConnection(sql);
                    try
                    {
                        con.Open();
                        SqlCommand com = new SqlCommand("delete  from admin  where username='"+l.Text+"'", con);
                        com.ExecuteNonQuery();
                        
                    }
                    finally
                    {
                        con.Close();
                    }
                }
               
            }
            represent();

        }
    }
}