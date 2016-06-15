<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMasterPage.master" AutoEventWireup="true" CodeFile="funUser.aspx.cs" Inherits="admin_funUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>巡视信息查询</title>
    <link href="../Style/bootstrap.min.css" rel="stylesheet" />
    <link href="../Style/daterangepicker.css" rel="stylesheet" />
    <script src="../Js/jquery-1.12.3.min.js"></script>
    <script src="../Js/bootstrap.min.js"></script>
    <script src="../Js/moment.min.js"></script>
    <script src="../Js/daterangepicker.js"></script>
    <link href="../Style/nodeIndex.css" rel="stylesheet" />
    <link href="../Style/cmd.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="Form1"  runat="server">
    <div id="body">
        <div class="conditions "><%--条件--%>
            用户名：
<asp:TextBox ID="userName" runat="server" CssClass="box userName"></asp:TextBox>
             系部：
             <asp:DropDownList ID="DropDownList2" runat="server" CssClass="box">
                <asp:ListItem>电信工程系</asp:ListItem>
                <asp:ListItem>综合基础部</asp:ListItem>
                <asp:ListItem>机电系</asp:ListItem>
                <asp:ListItem>继续教育部</asp:ListItem>
            </asp:DropDownList>
        
        <asp:Button ID="Button1" runat="server" CssClass="button" Text="查询" />
             <asp:Button ID="Button2" runat="server" CssClass="button" Text="删除" OnClick="Button2_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="gridView">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            </div>
        </div>
        </form>
     <script type="text/javascript">
         $(document).ready(function () {
             $('#config-demo22').daterangepicker();
         });
    </script>
</asp:Content>
