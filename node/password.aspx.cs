using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class node_password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void login_Click(object sender, EventArgs e)
    {
        //代码作用：提示用户 密码修改成功。
        //pswname.Style["display"] = "block";
        //代码作用：提示用户 旧密码错误。
        //lopsw.Style["display"] = "block";

        //清空显示
        pswname.Style["display"] = "none";
        //避免新密码为空密码
        if ((password1.Text.Trim() != "")&&(password2.Text.Trim()!= ""))
        {
                 User u = new User();
                string userPassword=u.getUserPasswordByUsername(Session["username"].ToString()).ToUpper();
                string inputPassword = u.encryption(password.Text.Trim().ToString()).ToUpper();
                string newPassword = u.encryption(password1.Text.Trim().ToString()).ToUpper();
                if (userPassword == inputPassword)
                {
                    //将加密的数据存入数据库
                    u.updatePasswordByUsername(Session["username"].ToString(), newPassword);
                    pswname.Style["display"] = "block";
                }
                else
                {
                    lopsw.Style["display"] = "block";
                }
                

        }

       
        
    }
}