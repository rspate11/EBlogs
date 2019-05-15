using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.HtmlControls;

public partial class Default3 : System.Web.UI.Page
{
    
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

         
       
        conn.Open();
        string s,s2;
        
        SqlCommand cmd = new SqlCommand("select * from Blogdata where Id=@s", conn);
        cmd.Parameters.AddWithValue("@s", Session["pstid"].ToString());
        SqlDataReader rd = cmd.ExecuteReader();

        while (rd.Read())
        {
            s = rd["Bodytxt"].ToString();
            s2 = rd["Username"].ToString();
            // l2.Text = s;

            char[] c = new char[s.Length];
            int i = 0;
            c = s.ToCharArray();
            string s1 = null;
            foreach (char c1 in c)
            {
                s1 = s1 + c1;
                if (i == 57)
                {
                    i = 0;
                    s1 = s1 + "<br>";
                }
                i++;
            }

            l2.Text = s1;

        }
        rd.Close();
        conn.Close();

        conn.Open();
        SqlDataAdapter sd = new SqlDataAdapter("select * from comment where Id='" + Session["pstid"] + "' ", conn);

        DataTable dtable = new DataTable();
        sd.Fill(dtable);
        for (int i = 0; i < dtable.Rows.Count; i++)
        {
            comment(dtable.Rows[i]);
        }
        conn.Close();
    }
     public void comment(DataRow dr)
        {
            
            HtmlGenericControl d = new HtmlGenericControl("div");
            d.Attributes.Add("style", " width:90%;margin-left:60px ; background-color:#d0ece7; margin-top:10px");
            d.Attributes.Add("class", "alert");
            d.Attributes.Add("id","comments");
            Table t = new Table();
            TableRow tr = new TableRow();
            TableCell c1 = new TableCell();
            TableCell c2 = new TableCell();
           // SqlDataAdapter s1 = new SqlDataAdapter("select name,image from Userr where emailid='" + dr["emailid"] + "'", conn);
           // DataTable imgg = new DataTable();
          //  s1.Fill(imgg);
          //  Image img = new Image();
           // img.ImageUrl = "upload/"+ imgg.Rows[0]["image"];
          //  img.CssClass = "img-circle";
          //  img.Width = 80;
          //  img.Height = 80;
           
            tr.Controls.Add(c1);
            tr.Controls.Add(c2);
            t.Controls.Add(tr);
            d.Controls.Add(t);
            Label l2 = new Label();
            c1.Width = 150; //COMMENT FROM COMMENT TABLE    

            l2.Text = dr["comment"].ToString();
           
            c2.Controls.Add(l2);

            Label l1 = new Label();

            // conn.Open();
            string s3;
            SqlCommand cmd2 = new SqlCommand("select Username from comment where comment=@s3", conn);
            cmd2.Parameters.AddWithValue("@s3", l2.Text);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                s3 = rd2["Username"].ToString();
                l1.Text = s3;
               
            }
            rd2.Close();
            //  conn.Close();

            // l1.Text = Session["pstid"].ToString();
            Lcomment.Text = null;
            // c1.Controls.Add(img);
            c1.Controls.Add(l1);
            main2.Controls.Add(d);
        }
    protected void my(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmmnt=new SqlCommand("insert into comment(Id,comment,Username) values('"+Session["pstid"]+"',@comment,'"+Session["value"]+"')",conn);
            cmmnt.Parameters.AddWithValue("@comment",comment_text.Text);
            cmmnt.ExecuteNonQuery();
            conn.Close();
            comment_text.Text = null;
            Response.Redirect("comment.aspx");
        }

}


