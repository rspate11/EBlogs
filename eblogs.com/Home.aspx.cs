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

public partial class Default3 : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

        if(Session["value"]!=null)
        {
            Label1.Text = Session["value"].ToString();
        }
        else
        {
            Label1.Text = "Guest";
        }

        SqlDataAdapter s1 = new SqlDataAdapter("select Id,Title,Bodytxt,Username,category from Blogdata", conn);
        conn.Open();

        DataTable dt = new DataTable();
        s1.Fill(dt);
        string[] pst = new string[dt.Rows.Count];
        string[] pstid = new string[dt.Rows.Count];
        string[] pstname = new string[dt.Rows.Count];
        string[] psttitle = new string[dt.Rows.Count];
        string[] b_id = new string[dt.Rows.Count];
        string[] b_id1 = new string[dt.Rows.Count];
        int i = 0;

        foreach (DataRow row in dt.Rows)
        {

            pst[i] = row["Bodytxt"].ToString();
            pstid[i] = row["Id"].ToString();
            pstname[i] = row["Username"].ToString();
            psttitle[i] = row["Title"].ToString();
            b_id[i] =+0 + pstid[i];
            
            b_id1[i] = +0 + b_id[i];


           // String var = pstid[i];
            i++;

        }


        conn.Close(); 



        //comment//
       





        for (i = pst.Length - 1; i >= 0; i--)
        {
            HtmlGenericControl d1 = new HtmlGenericControl("div");
            //d1.ID = Convert.ToString(i + 1);
            d1.Attributes.Add("style", "height:auto;margin-top:2%;background-color:orange;");
           
           //d1.CssClass = " w3-orange w3-hover-text-pink";
            Table t = new Table();
           // t.CssClass = "w3-orange w3-hover-text-pink";
            TableRow tr = new TableRow();
            TableCell tc1 = new TableCell();
            TableCell tc2 = new TableCell();
            t.Rows.Add(tr);
            tr.Cells.Add(tc1);
            tr.Cells.Add(tc2);
            t.CellSpacing = 10;
            Image i1 = new Image();
            i1.CssClass = "w3-left w3-circle w3-margin-right";

            i1.Width = 80;
            i1.Height = 80;
           // string semailid = (string)Session["value"];
           /* conn.Open();
                String s2 =" select Username from Blogdata where ID='"+pstid[i]+"'";
                SqlCommand com = new SqlCommand(s2, conn);
               com.ExecuteNonQuery();
            */
          /*  conn.Open();
            SqlDataAdapter s2 = new SqlDataAdapter("select Username from BlogData where Id='" + Convert.ToInt32(pstid[i]) + "'", conn);
            DataTable dt3 = new DataTable();
            s2.Fill(dt3);
               SqlDataAdapter s3 = new SqlDataAdapter("select strname from UserData1 where UserName ='"+dt3.Rows[0][0].ToString()+"' ", conn);

                DataTable dt1 = new DataTable();
                s3.Fill(dt1);
                string v = dt1.Rows[0]["strname"].ToString();
                Label3.Text = v;
            
          //  int count = 0;
          //  tc2.Text = "<h3><b>" + (string)dt1.Rows[0]["name"];

                conn.Close();
            */


           
            //int count = 0;

            //blogs//
            HtmlGenericControl d = new HtmlGenericControl("div");
            // d.ID =Convert.ToString(i);
            d.Attributes.Add("style", "height:auto;width:75%;margin-left:10%;background-color:orange;margin-top:0px");
          //  d.Attributes.Add("class", "w3-orange w3-hover-text-pink");
            Label l = new Label();
            l.Attributes.Add("style", "font-family;color: #000000;font-size:large");
            //l.CssClass = "w3-orange w3-hover-pink";
            Label l1 = new Label();
            l1.Attributes.Add("style", "color: #800000; font-style: normal; font-family: 'Copperplate Gothic Bold'");
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
                j++;
            }
            for (int q = 0; q < 1; q++)
            {

                x2 = x2 + "<br>";


            }
            l2.Text = "<b>" + x2;
               

            //div//

            string p = pst[i];
           // char[] c = new char[p.Length];
           // c = p.ToCharArray();
            int k = 0;
            string x = null;
            foreach (char c5 in p)
            {
                x = x + c5;
                if (k ==90)
                {
                    k = 0;
                    x = x + "<br>";

                }
                k++;
            }
            for (int q = 0; q < 1; q++)
            {

                x = x + "<br>";
                
                
            }//a blog 
           
            l.Text = "<b>" + x;
           
            d.Controls.Add(l1);
          
            d.Controls.Add(l2);
            d.Controls.Add(l);

            //like//
          
           // Button b1 = new Button();

           // b1.Text = "Like  " + count;
            //b1.ID = pst[i]+500.ToString();
           // b1.Click += new EventHandler(likeclick);
           // b1.CssClass = "w3-button w3-theme-d1 w3-margin-bottom";
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

            Button b4 = new Button();
            b4.Text = "Delete";
            b4.ID = b_id1[i].ToString();
            b4.Click += new EventHandler(btnclk2);
            b4.CssClass = "w3-btn w3-black w3-border w3-round-xlarge ";
            if (Label1.Text != "Guest")
            {
                if (Label1.Text == " vrunda12")
                {
                    b4.Visible = true;
                }
                else
                {
                    b4.Visible = false;
                }
               
            }
             else
                {
                    b4.Visible = false;
                }
               

           
       
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
            ltc3.Controls.Add(b3);
            ltc4.Controls.Add(b4);
          //  i1.ImageUrl = "/upload/" + dt1.Rows[0]["strname"].ToString();

           // tc1.Controls.Add(i1);

            ltc1.Attributes.Add("style", "width:100px");

            post.Controls.Add(d1);
            d1.Controls.Add(t);
            d1.Controls.Add(d);
            d1.Controls.Add(lt);



        }
        conn.Close();
    }

    //to get which comment button is clicked
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

   public void btnclk2(object sender, EventArgs e)
   {

       Button delete = sender as Button;
       // identify which button was clicked and perform necessary actions
       delete.Text = delete.ID;
       Session["pstid2"] = delete.ID;

       SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
       conn4.Open();

       string delete2 = "delete  from comment where Id= @delete1";
       SqlCommand com4 = new SqlCommand(delete2, conn4);
       com4.Parameters.AddWithValue("@delete1", delete.ID);

       com4.ExecuteNonQuery();
       conn4.Close();




       SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
       conn3.Open();

       string delete1 = "delete  from Blogdata where Id= @delete";
       SqlCommand com3 = new SqlCommand(delete1, conn3);
       com3.Parameters.AddWithValue("@delete", delete.ID);

       com3.ExecuteNonQuery();
       conn3.Close();
       Response.Redirect("Home.aspx");
       //here button id is post id so, by tracking post id we can get no of comments and comment also
       //for no of comment take a loop lets 2 cooments are there

   }



  /*  public void likeclick(object sender, EventArgs e)
    {
        Button like = sender as Button;
        Session["likeid"] = Convert.ToInt16(like.ID) - 500;
        SqlCommand s1 = new SqlCommand("select likes from Post_MCQ where mcq_id='" + Session["likeid"] + "'", con);
        SqlDataReader dr = s1.ExecuteReader();

        int l_count;
        while (dr.Read())
        {
            l_count = Convert.ToInt32(dr["likes"]);
            l_count++;

            SqlCommand s2 = new SqlCommand("insert into Post_MCQ(likes) values('" + l_count + "')", con);
            s2.ExecuteNonQuery();
        }
    }*/


}