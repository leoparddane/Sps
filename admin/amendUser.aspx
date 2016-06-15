<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="amendUser.aspx.cs" Inherits="admin_amendUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../Style/addUser.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <table >
        <thead>
            <tr>
                <td></td>
                <td class="thead"><h2>用户修改</h2>
                    <td></td>
            </td>
            </tr>
        </thead>
         <tr>
            <td class="tdOne">修改的用户:</td>
            <td class="tdTwo">
                <asp:TextBox ID="userName" runat="server" CssClass="repeat"></asp:TextBox>
            </td>
            <td class="tdS">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="用户名不能为空！" ControlToValidate="userName" CssClass="text"></asp:RequiredFieldValidator>  
            </td>
        </tr>
        <tr>
            <td class="tdOne">真实姓名：</td>
            <td class="tdTwo">
                <asp:TextBox ID="name" runat="server" CssClass="repeat"></asp:TextBox>
            </td>
            <td class="tdS">
                 &nbsp;</td>
        </tr>
        <tr>
            <td class="tdOne">所属系部：</td>
            <td class="tdTwo">
                 <asp:DropDownList ID="DropDownList1" runat="server" CssClass="repeat" Width="177px">
                <asp:ListItem>电信工程系</asp:ListItem>
                <asp:ListItem>综合基础部</asp:ListItem>
                <asp:ListItem>机电系</asp:ListItem>
                <asp:ListItem>继续教育部</asp:ListItem>
            </asp:DropDownList>
            </td>
            <td class="tdS"></td>
        </tr>
        <tr>
            <td class="tdOne">密码：</td>
            <td class="tdTwo">
                <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="repeat"></asp:TextBox>
            </td>
            <td class="tdS">
                 &nbsp;</td>
        </tr>
        <tr>
            <td class="tdOne">确认密码：</td>
            <td class="tdTwo">
                <asp:TextBox ID="passwordTo" runat="server" TextMode="Password" CssClass="repeat"></asp:TextBox>
            </td>
            <td class="tdS">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="两此密码不同!!"
                     ControlToCompare="passwordTo" ControlToValidate="password" Operator="Equal"
                    ></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="tdOne">用户权限：</td>
            <td class="tdTwo">
                 <asp:DropDownList ID="DropDownList2" runat="server" CssClass="repeat" Width="177px">
                <asp:ListItem>普通用户</asp:ListItem>
                <asp:ListItem>管理员</asp:ListItem>
            </asp:DropDownList>
            </td>
            <td class="tdS"></td>
        </tr>
        <tr>
            <td class="tdOne"></td>
            <td class="tdTwo">
                <asp:Button ID="Button1" runat="server" Text="确认" CssClass="repeat button" Width="177px" OnClick="Button1_Click" /></td>
            <td class="tdS"></td>
        </tr>
    </table>
    </form>
</asp:Content>
