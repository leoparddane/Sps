using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class node_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Response.Write("<script>alert('" + Session["username"].ToString() + "');</script>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //成功后提示
        // Response.Write("<script>alert("数据保存成功！！！确认后继续");</script>");
    }
}