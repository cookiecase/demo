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
    public partial class Edit : System.Web.UI.Page
    {
        private static  string consql = ConfigurationManager.AppSettings["sql"];
        public SqlConnection con = new SqlConnection(consql);
        string id;//选择的角色id
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request["a"];
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("select RoleName from Role", con);//给管理员选择角色
                com.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
                RoleType.DataSource = ds;
                RoleType.DataTextField = "rolename";
                RoleType.DataBind();

            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("update role set rolename=@name,roletype=@type,permission=@per where RoleName=@id", con);
                com.Parameters.AddWithValue("@name", RoleName.Text);
                com.Parameters.AddWithValue("@type", RoleType.SelectedItem.Value.ToString());
                com.Parameters.AddWithValue("@id", id);
                if (CheckBox1.Checked)
                {
                    com.Parameters.AddWithValue("@per", true);
                }
                else
                {
                    com.Parameters.AddWithValue("@per", false);
                }
                com.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }
}