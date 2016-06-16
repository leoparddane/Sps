<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminIndex.aspx.cs" Inherits="admin_adminIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>登录页面</title>
    <link rel="stylesheet" href="../Style/bootstrap.min.css" />
    <link rel="stylesheet" href="../Style/bootstrap-theme.min.css" />
    <script src="../Js/jquery.min.js"></script>
    <script src="../Js/bootstrap.min.js"></script>
    <script src="../Js/index.js"></script>
    <link rel="stylesheet" href="../Style/adminIndex.css" />
</head>
<body>
 <div id="bodyimg" ></div>
<div class="onld" id="onld">
<div class="container">
    <form id="form1" runat="server" class="form-box bodybox">
   <h2 class="form-signin-heading">后台登陆</h2>
            <label for="inputEmail" class="only">name</label>
       
         
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="用户名不能为空！" ControlToValidate="inputEmail" CssClass="text"></asp:RequiredFieldValidator>   
           <asp:TextBox  id="inputEmail" class="form-control" required="required" placeholder="name" runat="server"></asp:TextBox>     
        <label for="inputPassword" class="only">Password</label>

         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="密码不能为空！" ControlToValidate="inputPassword" CssClass="text"></asp:RequiredFieldValidator>

        <asp:TextBox  id="inputPassword" class="form-control" placeholder="Password" required="required" runat="server"></asp:TextBox>
         <br />
        <asp:Button id="btnindex" class="btn btn-lg btn-primary btn-block"  runat="server" Text="登录" OnClick="login_Click" />
        <br />
           <asp:Label ID="pswname" runat="server" Text="用户名或密码错误！！！" style="display:none; color:red;"></asp:Label> 
         
         <a href="../index.aspx" class="goadmin">用户登陆</a>
        </form>
    </div>
</div>
</body>
</html>
