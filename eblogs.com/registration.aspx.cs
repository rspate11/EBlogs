using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO; 


public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select  count(*) from UserData1 where UserName='" + TextBoxUN.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if(temp==1)
            {
                Response.Write("user exits");
            }


            conn.Close();
        }
    }
    protected void Button_r_Click(object sender, EventArgs e)
    {
        try
        {

            Guid newGUID = Guid.NewGuid();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select  count(*) from UserData1 where UserName='" + TextBoxUN.Text + "'";
            SqlCommand com1 = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com1.ExecuteScalar().ToString());
            conn.Close();
            if (temp== 0 )
            {

               
                    conn.Open();
                    string insertQue = "insert into UserData1 (Id,UserName,Email,Password,Country) values (@id,@Uname,@email,@password,@country)";
                    SqlCommand com = new SqlCommand(insertQue, conn);
                    com.Parameters.AddWithValue("@id", newGUID.ToString());
                    com.Parameters.AddWithValue("@Uname", TextBoxUN.Text);
                    com.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                    com.Parameters.AddWithValue("@password", TextBoxPassword.Text);
                    com.Parameters.AddWithValue("@country", TextBoxConfirm.Text);
                   // com.Parameters.AddWithValue("@strname", strname);

                    com.ExecuteNonQuery();
                    Response.Redirect("login1.aspx");
                    Response.Write("registration is successful");
                   



                    conn.Close();
                    
                

            }
            else
            {
                Response.Write("Already Exist");
            }
        }
        catch (Exception ex)
        {
            Response.Write("error:" + ex.ToString());
        }
    }
}