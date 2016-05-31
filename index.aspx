﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html>
<head>
<title>登录</title>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<link href="Style/index.css" rel="stylesheet" />
    <script src="Js/jquery-1.12.3.min.js"></script>
    <script src="Js/index.js"></script>
    <script>
        window.onload = function () {
            //$(function () {
            //    $("#name,#password").focus(function () {
            //        $("#name").val("");
            //        $("#password").val("");
            //    });
            //    $("#name,#password").blur(function () {
            //        $("#name").val("请输入用户名！！");
            //        $("#password").val("请输入密码！！");
            //    });
            //});
            //$("name").focus(function () {
            //    $("#name").text(" ");
            //});
            document.getElementById("login").onclick = function () {
                var nameV = document.getElementById("name").value;
                var password = $("#password").val();
                var nameA = $.trim(nameV);
                var pwd = $.trim(password);
                if (nameA.length > 0) {
                    
                }
                else {
                    alert("请输入用户名！！！"); 
                }
                if (pwd.length > 0) {
                    
                }
                else {
                    alert("请输入密码！！！");
                }
            }
        }
    </script>

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
          <asp:TextBox ID="password" CssClass="indexLogin_input" TextMode="Password" runat="server"></asp:TextBox>            
         <asp:Button ID="login" runat="server" Text="登录" CssClass="indexLogin_input indexLogin_input_go" />

    </form>
	</div>	
            </div>
    <script>
    </script>
        <div class="footer"></div>
</body>
</html>