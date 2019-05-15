using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Addblog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void sub_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            conn.Open();
            string insertblogs = "insert into Blogdata(Title,Bodytxt) values (@title,@bodytxt)";
            SqlCommand com = new SqlCommand(insertblogs, conn);

            com.Parameters.AddWithValue("@title", Title.Text);
            com.Parameters.AddWithValue("@bodytxt", bodytxt.Text);



            com.ExecuteNonQuery();

            Response.Write(" succ");
            conn.Close();
        }
        catch (Exception ae)
        {
            Response.Write("error:" + ae.ToString());
        }


    }
}