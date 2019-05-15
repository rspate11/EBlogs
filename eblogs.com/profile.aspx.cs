using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)

   {
      /* string s;
       SqlConnection conn8 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
    
       SqlDataAdapter s5 = new SqlDataAdapter("select msg from adminmsg where Username='"+Session["value"].ToString()+"'", conn8);
       conn8.Open();

       DataTable dt5 = new DataTable();
       s5.Fill(dt5);
       string[] usr = new string[dt5.Rows.Count];

       int i5 = 0;

       foreach (DataRow row1 in dt5.Rows)
       {

           usr[i5] = row1["msg"].ToString();
           Label5.Text = usr[i5];

           i5++;
          
       }
      
       conn8.Close();
        */
  
        if(Session["value"]==null)
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have to login first!')", true);
            Label1.Visible = false;
            Response.Redirect("login1.aspx");
        }

       
         else if (Session["value"] != null)
        {

            Label2.Text = Session["value"].ToString();
           // string name = Label2.Text;

           /* SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn.Open();

          
            SqlCommand com = new SqlCommand("select Email from UserData1 where UserName like @username" , conn);
            com.Parameters.AddWithValue("@username", Label2.Text + "%");
            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                Label4.Text = "" + reader["Email"];
            }

            else
            {
                
            }
            conn.Close();*/
        }
        if (!IsPostBack)
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
           


            SqlCommand com1 = new SqlCommand("select follower from follow where following like @username", conn1);
            conn1.Open();
            com1.Parameters.AddWithValue("@username", Session["value"] + "%");
            
                DropDownList1.DataSource = com1.ExecuteReader();
                DropDownList1.DataTextField = "follower";
                
                DropDownList1.DataBind();



               
                conn1.Close();
            }
        if(!IsPostBack)
        {
            SqlConnection conn7 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);



            SqlCommand com7 = new SqlCommand("select Username from follower where follower like @follower1", conn7);
            conn7.Open();
            com7.Parameters.AddWithValue("@follower1", Session["value"] + "%");

            DropDownList2.DataSource = com7.ExecuteReader();
            DropDownList2.DataTextField = "Username";

            DropDownList2.DataBind();




            conn7.Close();
        }



        if(!IsPostBack)
        {
            SqlConnection conn6 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);



            SqlCommand com6 = new SqlCommand("select follower from follower where Username like @username", conn6);
            conn6.Open();
            com6.Parameters.AddWithValue("@username", Session["value"] + "%");

            DropDownList3.DataSource = com6.ExecuteReader();
            DropDownList3.DataTextField = "follower";

            DropDownList3.DataBind();




            conn6.Close();
        }

       if(!IsPostBack)
       {
           SqlConnection conn9 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);



           SqlCommand com9 = new SqlCommand("select msg from adminmsg where Username like @username2", conn9);
           conn9.Open();
           com9.Parameters.AddWithValue("@username2", " "+ Session["value"].ToString());

           DropDownList4.DataSource = com9.ExecuteReader();
           DropDownList4.DataTextField = "msg";

           DropDownList4.DataBind();
           conn9.Close();
          
       }
           

        




        
        
            SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);

            conn5.Open();
            SqlDataAdapter s1 = new SqlDataAdapter("select Id,Title,Bodytxt,Username,category from Blogdata where Username='" + Session["value"] + "'", conn5);


            DataTable dt = new DataTable();
            s1.Fill(dt);
            string[] pst = new string[dt.Rows.Count];
            string[] pstid = new string[dt.Rows.Count];
            string[] pstname = new string[dt.Rows.Count];
            string[] psttitle = new string[dt.Rows.Count];
            string[] b_id = new string[dt.Rows.Count];
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {

                pst[i] = row["Bodytxt"].ToString();
                pstid[i] = row["Id"].ToString();
                pstname[i] = row["Username"].ToString();
                psttitle[i] = row["Title"].ToString();
                b_id[i] = +0 + pstid[i];

                // String var = pstid[i];
                i++;

            }


           conn5.Close();
            //comment//
            /* SqlDataAdapter s2 = new SqlDataAdapter("select Id from Blogdata", conn);
             conn.Open();

             DataTable dt1 = new DataTable();
             s2.Fill(dt1);
       
             string[] pstid1 = new string[100];
        
     
             int i1 = 0;

             foreach (DataRow row1 in dt1.Rows)
             {

           
                 pstid1[i1] = row1["Id"].ToString();
            
       

                 i1++;

             }
            conn.Close();*/







            for (i = pst.Length - 1; i >= 0; i--)
            {
                HtmlGenericControl d1 = new HtmlGenericControl("div");
                //d1.ID = Convert.ToString(i + 1);
                d1.Attributes.Add("style", "height:auto;margin-top:2%;margin-bottom:2%;background-color:orange;");

                Table t = new Table();
                TableRow tr = new TableRow();
                TableCell tc1 = new TableCell();

                TableCell tc2 = new TableCell();
                t.Rows.Add(tr);
                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                t.CellSpacing = 10;

                string semailid = (string)Session["value"];
                //int count = 0;

                //blogs//
                HtmlGenericControl d = new HtmlGenericControl("div");
                // d.ID =Convert.ToString(i);
                d.Attributes.Add("style", "height:auto;width:89%;margin-left:5%;background-color:orange;margin-top:0px;margin-right:5%,margin-bottom:0px");
                Label l = new Label();
                l.Attributes.Add("style", "font-family;color: #000000;font-size:large");
                Label l1 = new Label();
                l1.Attributes.Add("style", "color: #800000; font-style: normal; font-family: 'Copperplate Gothic Bold'font-size:xxlarge;");

                Label l2 = new Label();
                l2.Attributes.Add("style", "font-family: 'Copperplate Gothic Bold'; color: #CC0000; text-decoration: underline overline; font-size:xxlarge");




                string p1 = pstname[i];
                char[] c1 = new char[p1.Length];
                c1 = p1.ToCharArray();
                int j = 0;
                string x1 = null;
                foreach (char c2 in c1)
                {
                    x1 = x1 + c2;
                    if (j == 110)
                    {
                        j = 0;
                        x1 = x1 + "<br>";

                    }
                    j++;
                }
                for (int q = 0; q < 1; q++)
                {

                    x1 = x1 + "<br>";


                }

                l1.Text = "<b>" + x1;

                string p2 = psttitle[i];
                char[] c3 = new char[p2.Length];
                c3 = p2.ToCharArray();
                int temp = 0;
                string x2 = null;
                foreach (char c4 in c3)
                {
                    x2 = x2 + c4;
                    if (temp == 110)
                    {
                        j = 0;
                        x2 = x2 + "<br>";

                    }
                    temp++;
                }
                for (int q = 0; q < 1; q++)
                {

                    x2 = x2 + "<br>";


                }
                l2.Text = "<b>" + x2;


                //div//

                string p = pst[i];
                char[] c = new char[p.Length];
                c = p.ToCharArray();
                int k = 0;
                string x = null;
                foreach (char c5 in c)
                {
                    x = x + c5;
                    if (k == 90)
                    {
                        k = 0;
                        x = x + "<br>";

                    }
                    k++;
                }
                for (int q = 0; q < 1; q++)
                {

                    x = x + "<br>";


                }

                l.Text = "<b>" + x;

                d.Controls.Add(l1);

                d.Controls.Add(l2);
                d.Controls.Add(l);
                Button b2 = new Button();
                b2.Text = "Comment";
                b2.ID = pstid[i].ToString();
                b2.Click += new EventHandler(btnclk);
                b2.CssClass = "w3-button w3-black  w3-border w3-round-xlarge ";
                Table lt = new Table();

                TableRow ltr = new TableRow();
                TableCell ltc1 = new TableCell();
                TableCell ltc2 = new TableCell();
                TableCell ltc3 = new TableCell();
                TableCell ltc4 = new TableCell();

                lt.Rows.Add(ltr);
                ltr.Cells.Add(ltc1);
                ltr.Cells.Add(ltc2);
                ltr.Cells.Add(ltc3);
                ltr.Cells.Add(ltc4);

                //  ltc1.Controls.Add(b1);
                ltc2.Controls.Add(b2);
                ltc1.Attributes.Add("style", "width:100px");


                post.Controls.Add(d1);
                d1.Controls.Add(t);
                d1.Controls.Add(d);
                 d1.Controls.Add(lt);

            }
        
        
    }

    public void btnclk(object sender, EventArgs e)
    {


        if (Session["value"] == null)
        {

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have to login first!')", true);

        }
        else
        {
            Button comment = sender as Button;
            // identify which button was clicked and perform necessary actions
            comment.Text = comment.ID;
            Session["pstid"] = comment.ID;
            Response.Redirect("comment.aspx");
            //here button id is post id so, by tracking post id we can get no of comments and comment also
            //for no of comment take a loop lets 2 cooments are there
        }
    }

   /* protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
        conn.Open();

        string insert = "insert into follow(following,follower) values (@following,@follower)";
        SqlCommand com = new SqlCommand(insert, conn);

        com.Parameters.AddWithValue("@following", Label2.Text);
        com.Parameters.AddWithValue("@follower", Session["value"].ToString());
       
        com.ExecuteNonQuery();
        conn.Close();
        Response.Redirect("profile.aspx");
       
    }*/

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //ClientScriptManager CSM = Page.ClientScript;
        // CSM.RegisterClientScriptBlock(this.GetType(), "confirm","show();", true);
        // string xyz = DropDownList1.SelectedItem.ToString();
        string confirmValue = Request.Form["confirm_value"];
        if (confirmValue == "Yes")
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You accepted!')", true);
            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn2.Open();

            string insert = "insert into follower(Username,follower) values (@username,@follower1)";
            SqlCommand com2 = new SqlCommand(insert, conn2);

            com2.Parameters.AddWithValue("@username", Session["value"].ToString());
            com2.Parameters.AddWithValue("@follower1", DropDownList1.SelectedItem.Text);

            com2.ExecuteNonQuery();
            conn2.Close();

            SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn3.Open();

            string delete = "delete  from follow where follower=@follower2";
            SqlCommand com3 = new SqlCommand(delete, conn3);
            com3.Parameters.AddWithValue("@follower2", DropDownList1.SelectedItem.Text);


            com3.ExecuteNonQuery();
            conn3.Close();
            Response.Redirect("profile.aspx");


        }
        else
        {

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You declined the request!')", true);

            SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn4.Open();

            string delete = "delete  from follow where follower=@follower3";
            SqlCommand com4 = new SqlCommand(delete, conn4);
            com4.Parameters.AddWithValue("@follower3", DropDownList1.SelectedItem.Text);


            com4.ExecuteNonQuery();
            conn4.Close();
            Response.Redirect("profile.aspx");
        }
    }

 

    protected void Button1_Click(object sender, EventArgs e)
    {
        DropDownList1.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DropDownList2.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        DropDownList3.Visible = true;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        DropDownList4.Visible = true;
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("home1.aspx");
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
       /* SqlConnection conn7 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
        conn7.Open();

        string delete = "delete  from follow where follower=@follower7";
        SqlCommand com7 = new SqlCommand(delete, conn7);
        com7.Parameters.AddWithValue("@follower7", Session["value"].ToString());


        com7.ExecuteNonQuery();
        conn7.Close();
        Response.Redirect("profile.aspx");
        


        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You accepted!')", true);
        string confirmValue1 = Request.Form["confirm_value1"];
        if (confirmValue1 == "Yes")
        {
            Response.Redirect("Home.aspx");
        }
        string confirmValue1 = Request.Form["confirm_value1"];
        if (confirmValue1 == "Yes")
        {
            

            SqlConnection conn7 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn7.Open();

            string delete1 = "delete from adminmsg where Username =@f";
            SqlCommand com7 = new SqlCommand(delete1, conn7);
            com7.Parameters.AddWithValue("@f", Session["value"].ToString());


            com7.ExecuteNonQuery();
            conn7.Close();
            Response.Redirect("travelling.aspx");

        }
        else
        {

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You declined the request!')", true);

            SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn4.Open();

            string delete = "delete  from follow where follower=@follower3";
            SqlCommand com4 = new SqlCommand(delete, conn4);
            com4.Parameters.AddWithValue("@follower3", DropDownList1.SelectedItem.Text);


            com4.ExecuteNonQuery();
            conn4.Close();
            Response.Redirect("profile.aspx");
        }
    */
    }
}
