using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration; 



public partial class login1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button_login_Click(object sender, EventArgs e)
    {

    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
    conn.Open();
    string checkuser = "select  count(*) from UserData1 where UserName='" + TextBoxUsername.Text + "'";
        SqlCommand com=new SqlCommand(checkuser,conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
       if(temp==1)
       {
           conn.Open();
           string checkpass="select Password from UserData1 where UserName='" + TextBoxUsername.Text + "'";
           SqlCommand passcom = new SqlCommand(checkpass, conn);
           string password = passcom.ExecuteScalar().ToString().Replace(" ","");
           if(password==TextBoxPassword.Text)
           {
               Session["value"] = " " + TextBoxUsername.Text;
               Response.Write("password is correct");
               if (Session["f2"]!= null)
               {
                    if (Session["f2"].ToString().Equals("a"))
                    {
                        Response.Redirect("Uploadblog.aspx");
                    }
                    
               }
              //Response.Redirect("Uploadblog.aspx");
               else
               {

                   Response.Redirect("home1.aspx");
               }

           }
           else
           {
              
               Response.Write("not correct");
           }
       }
       else
       {
           Response.Write("username is not correct");
       }
    }

}