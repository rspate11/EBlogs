using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string h2, h1, t2, t1;
    protected void Page_Load(object sender, EventArgs e)
    {
       

        if (Session["value"] == null)
        {
            // h2 = "/Account/login1.aspx";
            h1 = "/login1.aspx";
             t2 = "";
            t1 = "Log in";
        }
        else
        {
            h1 = "/profile.aspx";
            h2 = "/Default.aspx";
            t1 = "Profile";
            t2 = "Log out";
        }

       
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        Response.Redirect("registration.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("travelling.aspx");
    }
}
