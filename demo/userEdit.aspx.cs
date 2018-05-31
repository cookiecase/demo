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
    public partial class Add : System.Web.UI.Page
    {
        private string consql = ConfigurationManager.AppSettings["sql"];
        string postname;
        protected void Page_Load(object sender, EventArgs e)
        {
             postname= Request["a"];
            SqlConnection con = new SqlConnection(consql);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("select RoleName from Role",con);//给管理员选择角色
                com.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "RoleName";
                DropDownList1.DataBind();

            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            if (UserKey.Text == Confirm.Text)
            {
                string filePath = Server.MapPath("~/");
                string fileName = FileUpload1.PostedFile.FileName;
                if (fileName == null)
                {
                    Response.Write("<Script Language=JavaScript>alert('选择图片！');</Script>");
                }
                else
                {
                    string[] a = fileName.Split('.');
                    if (!(a[1] == "jpg" || a[1] == "png" || a[1] == "bmp"))
                    {
                        Response.Write("图片格式错误");
                    }
                    else
                    {
                        FileUpload1.SaveAs(filePath + fileName);
                        SqlConnection con = new SqlConnection(consql);
                        con.Open();
                        try
                        {
                            SqlCommand com = new SqlCommand("update admin set username=@name,userkey=@key,pic=@pic,Role=@role where username=@username", con);
                            com.Parameters.AddWithValue("@username", postname);
                            com.Parameters.AddWithValue("@name", UserName.Text);
                            com.Parameters.AddWithValue("@key", UserKey.Text);
                            com.Parameters.AddWithValue("@role", DropDownList1.SelectedValue.ToString());
                            com.Parameters.AddWithValue("@pic", fileName);
                            com.ExecuteNonQuery();

                        }
                        finally
                        {
                            con.Close();
                        }
                        Response.Write("<Script Language=JavaScript>alert('修改完成！');</Script>");
                    }
                }



            }
            else
            {
                Response.Write("<Script Language=JavaScript>alert('密码不一致！');</Script>");
            }
        }
            

       
    }
}