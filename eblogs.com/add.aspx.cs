using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;



public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {


        // Guid newGUID = Guid.NewGuid();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
        
        conn.Open();
        
        string insertQue = "insert into bill (Name,Email,PhoneNo,Place,Time,Amount,stringname) values (@Uname,@email,@phoneno,@place,@time,@amount,@stringname)";
        SqlCommand com = new SqlCommand(insertQue, conn);
        // com.Parameters.AddWithValue("@id", newGUID.ToString());
        com.Parameters.AddWithValue("@Uname", TextBox1.Text);
        com.Parameters.AddWithValue("@email", TextBox2.Text);
        com.Parameters.AddWithValue("@phoneno", TextBox3.Text);
        com.Parameters.AddWithValue("@place", RadioButtonList1.SelectedValue);
        com.Parameters.AddWithValue("@time", RadioButtonList2.SelectedValue);
        com.Parameters.AddWithValue("@amount", TextBox4.Text);
       
        
       




        if (FileUpload1.HasFile)
        {
            string strname = FileUpload1.FileName.ToString();
            Directory.CreateDirectory(Server.MapPath("~") + "\\upload");
            Response.Write(strname);
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/upload/") + strname);

            com.Parameters.AddWithValue("@stringname", strname);




        }

        // com.Parameters.AddWithValue("@strname", strname);

        com.ExecuteNonQuery();
        Label1.Text = "Payment is successfully done!";
       // Response.Redirect("login1.aspx");
        Response.Write("registration is successful");

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        RadioButtonList1.SelectedValue ="";
        RadioButtonList2.SelectedValue = "";
      


        conn.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string temp1="First Page";
        SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
        SqlDataAdapter s2 = new SqlDataAdapter("select Place from bill where Place='" + temp1 + "'", conn5);
        conn5.Open();

        DataTable dt5 = new DataTable();
        s2.Fill(dt5);
        int count = dt5.Rows.Count;
       

        

        TextBox4.Visible =true;
        if (RadioButtonList1.SelectedValue == "First Page" && RadioButtonList2.SelectedValue == "One Week")
        {
            if (count > 5)
            {
                Label1.Text = "SORRY! Page capacity is full ";
            }
            else
            {
                TextBox4.Text = "10000";
            
            }
            

        }
        if (RadioButtonList1.SelectedValue == "First Page" && RadioButtonList2.SelectedValue == "Two Weeks")
        {

            if (count > 5)
            {
                Label1.Text = "SORRY! Page capacity is full ";
            }
            else
            {
                TextBox4.Text = "15000";

            }
            
           
        }

        if (RadioButtonList1.SelectedValue == "Others" && RadioButtonList2.SelectedValue == "One Week")
        {
           
            TextBox4.Text = "5000";
        }
        if (RadioButtonList1.SelectedValue == "Others" && RadioButtonList2.SelectedValue == "Two Week")
        {
           
            TextBox4.Text = "9000";
        }

    }
}
  
    
