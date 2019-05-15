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
using System.Windows;


public partial class viewprofile : System.Web.UI.Page
{    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
protected void Page_Load(object sender, EventArgs e)
{
    if (Session["following"] != null)
    {
        Label2.Text = Session["following"].ToString();
    }
   if (Session["value"] != null && Session["following"] != null)
    {
        if (Session["value"].ToString() == Session["following"].ToString())
        {
            Button1.Visible = false;
        }
    }
    conn.Open();
    SqlDataAdapter s1 = new SqlDataAdapter("select Id,Title,Bodytxt,Username,category from Blogdata where Username='"+Session["following"]+"'", conn);
    

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


    conn.Close();
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

        Button b3 = new Button();
        b3.Text = " View profile";


        b3.ID = b_id[i].ToString();
        b3.Click += new EventHandler(btnclk1);
        b3.CssClass = "w3-button w3-black  w3-border w3-round-xlarge";
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
      //  ltc3.Controls.Add(b3);
       // ltc4.Controls.Add(b4);
        //  i1.ImageUrl = "/upload/" + dt1.Rows[0]["strname"].ToString();

       // tc1.Controls.Add(i1);

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


public void btnclk1(object sender, EventArgs e)
{

    if (Session["value"] == null)
    {
        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have to login first!')", true);

    }
    else
    {
        Button profile = sender as Button;
        // identify which button was clicked and perform necessary actions
        profile.Text = profile.ID;
        Session["pstid1"] = profile.ID;
        Session["flag"] = "1";
        conn.Open();

        string s2;
        SqlCommand cmd1 = new SqlCommand("select Username from Blogdata where Id=@s2", conn);
        cmd1.Parameters.AddWithValue("@s2", profile.ID);
        SqlDataReader rd1 = cmd1.ExecuteReader();
        while (rd1.Read())
        {
            s2 = rd1["Username"].ToString();

            Session["following"] = s2;
        }
        rd1.Close();
        conn.Close();
        Response.Redirect("viewprofile.aspx");
        //here button id is post id so, by tracking post id we can get no of comments and comment also
        //for no of comment take a loop lets 2 cooments are there
    }

}


protected void Button1_Click1(object sender, EventArgs e)
{
   
    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
     SqlDataAdapter s1 = new SqlDataAdapter("select follower from follower where Username='"+ Session["following"].ToString() +"'", conn1);
        conn1.Open();

        DataTable dt = new DataTable();
        s1.Fill(dt);
        string[] pst = new string[dt.Rows.Count];
       
        int i = 0;
        int flag=0;
        foreach (DataRow row in dt.Rows)
        {

            pst[i] = row["follower"].ToString();
           
            if(pst[i].ToString()!=Session["value"].ToString())
            {
            i++;
            }
            else
            {
                flag =1;
            }
            
            
        }


        conn1.Close();

        SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
        SqlDataAdapter s2 = new SqlDataAdapter("select follower from follow where following='" + Session["following"].ToString() + "'", conn2);
        conn2.Open();

        DataTable dt1 = new DataTable();
        s2.Fill(dt1);
        string[] pst1 = new string[dt1.Rows.Count];

        int j = 0;
        int f = 0;
        foreach (DataRow row1 in dt1.Rows)
        {

            pst1[j] = row1["follower"].ToString();

            if (pst1[j].ToString() != Session["value"].ToString())
            {
                j++;
            }
            else
            {
                f = 1;
            }


        }


        conn2.Close(); 


    if(flag==0 && f==0)
    {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn.Open();

            string insert = "insert into follow(following,follower) values (@following,@follower)";
            SqlCommand com = new SqlCommand(insert, conn);

            com.Parameters.AddWithValue("@following", Session["following"].ToString());
            com.Parameters.AddWithValue("@follower", Session["value"].ToString());

            com.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("viewprofile.aspx");
        
    }
     if(flag == 1)
    {
        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You are already following!')", true);
        
     }
    if(f==1)
    {
        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Request pending')", true);
    }
   // reader.Close();
   // conn1.Close();
}
protected void Button2_Click(object sender, EventArgs e)
{
    Response.Redirect("home1.aspx");
}
}