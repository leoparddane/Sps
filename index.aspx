<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html>
<head>
<title>登录</title>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<link href="Style/index.css" rel="stylesheet" />
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
                <asp:TextBox ID="password" runat="server" CssClass="indexLogin_input" TextMode="Password"></asp:TextBox>
              
         <asp:Button ID="go" runat="server" Text="登录" CssClass="indexLogin_input indexLogin_input_go" />
</form>
 <%--<!--<input type="text"  name="name" required ="required " placeholder="用户名"class="indexLogin_input indexLogin_input_mag "autofocus ="autofocus "runat="server" /><br />-->
   <!-- <input type="password"id="password"  name="password"required ="required " title="密码" placeholder="密码"class="indexLogin_input" />-->
     <!--   <input type="submit" value="登录" id="go" name="go" title="登录"class="indexLogin_input indexLogin_input_go" />-->--%>
    
	</div>	
            </div>
        <div class="footer"></div>
</body>
</html>