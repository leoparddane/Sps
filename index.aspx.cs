using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void login_Click(object sender, EventArgs e)
    {
        User u = new User();
        if (u.isPasswordCorrectByUsername(name.Text.Trim(), password.Text.Trim()))
        {
            Session["username"]=name.Text.Trim();
            Response.Redirect("node/index.aspx");
        }

    }
}