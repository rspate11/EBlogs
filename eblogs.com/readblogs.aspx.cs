using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class readblogs : System.Web.UI.Page
{
    private double i
    {
        get
        {
            return ViewState["i"] != null ? (double)ViewState["i"] : 9009;
        }
        set
        {
            ViewState["i"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["value"] != null)
        {

            Label2.Text = Session["value"].ToString();

        }
        else
        {
            Label2.Text = "Guest ";
        }
        if(!IsPostBack)
        {
          //  Like.Text = (i++).ToString();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
    }
   protected void Button_Like(object sender,EventArgs e)
    {
      //  Like.Text = (i++).ToString();
    }
}