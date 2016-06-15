<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cmd.aspx.cs" Inherits="node_cmd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>查询</title>
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
            日期：
        <input type="text" id="config-demo22" class="form-control input12 date" />

             班级：
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="box">
                <asp:ListItem>G1241</asp:ListItem>
                <asp:ListItem>G1242</asp:ListItem>
                <asp:ListItem>G1242</asp:ListItem>
            </asp:DropDownList>
        
        <asp:Button ID="Button1" runat="server" CssClass="button" Text="查询" />
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

