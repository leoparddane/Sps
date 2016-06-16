<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html>
<head>
<title>登录</title>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<link href="Style/index.css" rel="stylesheet" />
    <script src="Js/jquery-1.12.3.min.js"></script>
    <script src="Js/index.js"></script>
<<<<<<< HEAD
    <script>
    </script>
=======
>>>>>>> origin/master

</head>
    <body>
        <div class="header">
            <div class="indexTopleft">
                <img src="img/indexTopleft.gif" />
            </div>
             <div class="indexTopReight">
                 <img src="img/indexTopreight.gif" />
             </div>
            </div>
        <div class="main">
        <div class="indexLeft">
            <img src="img/indexLeft.gif" />
        </div>
       <div class="indexReight">
			<!--
            	作者：lrb
            	时间：2016-05-29
            	描述：下面是登录框
            -->
	 <form id="form2" runat="server" class="indexLogin">
         <asp:TextBox ID="name" CssClass="indexLogin_input indexLogin_input_mag" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="用户名不能为空！" ControlToValidate="name" CssClass="text"></asp:RequiredFieldValidator>

          <asp:TextBox ID="password" CssClass="indexLogin_input" TextMode="Password" runat="server"></asp:TextBox>
         
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="密码不能为空！" ControlToValidate="password" CssClass="text"></asp:RequiredFieldValidator>
              
         <asp:Button ID="login" runat="server" Text="登录" CssClass="indexLogin_input indexLogin_input_go" OnClick="login_Click" />
         <br />
         <asp:Label ID="pswname" runat="server" Text="用户名或密码错误！！！" style="display:none; color:red;"></asp:Label>
         <br />
         <a href="admin/adminIndex.aspx" class="goadmin">管理员登陆</a>
         
          </form>
	</div>	
            </div>
  
        <div class="footer"></div>
</body>
</html>