<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="password.aspx.cs" Inherits="node_password" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>修改密码</title>
    <link href="../Style/nodeIndex.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="indexReight">
			<!--
            	作者：lrb
            	时间：2016-05-29
            	描述：下面是修改框
            -->
	 <form id="form2" runat="server" class="indexLogin">
         旧密码:<asp:Label ID="lopsw" runat="server" Text="旧密码错误！！！" style="display:none; color:red;"></asp:Label><br />
          <asp:TextBox ID="password" CssClass="indexLogin_input" TextMode="Password" runat="server"></asp:TextBox>        
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="请输入旧密码！" ControlToValidate="password" CssClass="text"></asp:RequiredFieldValidator> 
         

          <br /><br />新密码:<br />
          <asp:TextBox ID="password1" CssClass="indexLogin_input" TextMode="Password" runat="server"></asp:TextBox>        
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ErrorMessage="请输入新密码！" ControlToValidate="password" CssClass="text"></asp:RequiredFieldValidator>

          <br /><br />确认密码:<br />
          <asp:TextBox ID="password2" CssClass="indexLogin_input" TextMode="Password" runat="server"></asp:TextBox> 
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="请确认新密码！" ControlToValidate="password" CssClass="text"></asp:RequiredFieldValidator>
              
         <asp:Button ID="login" runat="server" Text="保存" CssClass="indexLogin_input indexLogin_input_go" OnClick="login_Click" />
         <br />
         <asp:CompareValidator ID="CompareValidator2" ForeColor="Red" runat="server" ErrorMessage="两次密码输入不一致" ControlToValidate="password1" ControlToCompare="password2"></asp:CompareValidator> 
         <asp:Label ID="pswname" runat="server" Text="密码修改成功！！！" style="display:none; color:red;"></asp:Label>
         
          </form>
	</div>	
</asp:Content>

