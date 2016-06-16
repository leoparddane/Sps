using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("~/404.html");   
        }
        name.Text=Session["username"].ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["username"] = null;
        Response.Redirect("~/index.aspx");   
    }
}
