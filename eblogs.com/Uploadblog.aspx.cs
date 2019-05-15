using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class login1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["value"] != null)
        {
            Label2.Text = Session["value"].ToString();
        }
        else
        {
            Label2.Text = "Guest" ;
        }
        if(Session["new"]!=null)
        {
            TextboxTitle1.Text = Session["new"].ToString();
        }
        if(Session["new1"]!=null)
        {
            Textboxbodytxt.Text = Session["new1"].ToString();
        }
        if(Session["new2"]!=null)
        {
            DropDownList2.SelectedItem.Text = Session["new2"].ToString();
        }

    }
    protected void sub_Click(object sender, EventArgs e)

   {


       if (Label2.Text!="Guest")
       {
           
           try
           {
               SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
               conn.Open();
               string insertblogs = "insert into Blogdata(Title,Bodytxt,Username,category) values (@title,@bodytxt,@username,@category)";
               SqlCommand com = new SqlCommand(insertblogs, conn);

               com.Parameters.AddWithValue("@title", TextboxTitle1.Text);
               com.Parameters.AddWithValue("@bodytxt", Textboxbodytxt.Text);
               com.Parameters.AddWithValue("@username", Label2.Text);
               com.Parameters.AddWithValue("@category", DropDownList2.SelectedItem.Text);

              

             //  Response.Write(" succ");
           string admin=" "+"vrunda12";
           string s = Session["value"].ToString();
         
           if (s.Equals(admin)){


               SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
               SqlDataAdapter s1 = new SqlDataAdapter("select Username from UserData1", conn1);
               conn1.Open();

               DataTable dt = new DataTable();
               s1.Fill(dt);
               string[] usr = new string[dt.Rows.Count];

               int i = 0;
              
               foreach (DataRow row in dt.Rows)
               {

                   usr[i] = row["Username"].ToString();
                 
                   string usr1 = "insert into adminmsg(Username) values (@username1)";
                   SqlCommand com2 = new SqlCommand(usr1, conn1);
                   com2.Parameters.AddWithValue("@username1"," "+usr[i]);
                   com2.ExecuteNonQuery();

                   String temp = "E-Blogs has something new for you";
                   string updatetable = "Update adminmsg set msg='" + temp + "' where Username=@un1";
                  
                   SqlCommand com3 = new SqlCommand(updatetable, conn1);
                   com3.Parameters.AddWithValue("@un1", " " + usr[i]);
                   //com1.Parameters.AddWithValue("@title", temp);/

                   com3.ExecuteNonQuery();
                   i++;

               }

               Session["admin"] = "b";
               conn1.Close();

           }
           else {

               string temp1 = Session["value"].ToString();
               SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
               SqlDataAdapter s2 = new SqlDataAdapter("select follower from follower where Username='" +temp1 + "'", conn5);
               conn5.Open();

               DataTable dt5 = new DataTable();
               s2.Fill(dt5);
               string[] usr1 = new string[dt5.Rows.Count];

               int i = 0;

               foreach (DataRow row1 in dt5.Rows)
               {

                   usr1[i] = row1["follower"].ToString();

                   string usr2 = "insert into adminmsg(Username) values (@username2)";
                   SqlCommand com5 = new SqlCommand(usr2, conn5);
                   com5.Parameters.AddWithValue("@username2", " " + usr1[i]);
                   com5.ExecuteNonQuery();

                   String temp3 = Session["value"].ToString() + " has something new for you";
                   string updatetable1 = "Update adminmsg set msg='" + temp3 + "' where Username=@un ";

                   SqlCommand com6 = new SqlCommand(updatetable1, conn5);
                   com6.Parameters.AddWithValue("@un", " " + usr1[i]);
                   //com1.Parameters.AddWithValue("@title", temp);/

                   com6.ExecuteNonQuery();

                   i++;

               }

             //  Session["admin"] = "b";
              // conn5.Close();


             //  SqlConnection conn6 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
             //  conn6.Open();
               // String temp1 = "malay1";
              
               conn5.Close();



           }


                   com.ExecuteNonQuery();
                   conn.Close();

              
                  
               }
           catch (Exception ae)
           {
               Response.Write("error:" + ae.ToString());
           }
       }

       else
       {
           Session["new"] = " " + TextboxTitle1.Text;
           Session["new1"] = " " + Textboxbodytxt.Text;
           Session["new2"] = " " + DropDownList2.SelectedItem.Text;
           Session["f2"] = "a";
           Response.Redirect("login1.aspx");
       }


       

        TextboxTitle1.Text = "";
        Textboxbodytxt.Text = "";
        DropDownList2.SelectedItem.Text = "";

    }
    protected void TextboxTitle1_TextChanged(object sender, EventArgs e)
    { 
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Label2.Text != "Guest")
        {
            Response.Redirect("add.aspx");
        }
        else
        {

            Response.Redirect("login1.aspx");
        }
    }
}