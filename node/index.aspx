<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="node_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>巡视</title>
    <link href="../Style/nodeIndex.css" rel="stylesheet" />
    <script>
        window.onload = function () {
            var one = document.getElementById("yearTime");
            var dayTime = document.getElementById("dayTime");
            var TextBox1 = document.getElementById("TextBox1");
                var date = new Date();
                var year = date.getFullYear();
                var moonth = date.getMonth() + 1;
                var da = date.getDate();
                var d = date.getDay();
                var h = date.getHours();
                var t = date.getMinutes();
                var s = date.getSeconds();
                
                var weekday = ["星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六"];
                var datetime = year + "年" + moonth + "月" + da + "日" + "        " + weekday[d];
                one.innerText = datetime;

                if (h > 17 || h < 6) {
                    dayTime.innerText = "晚上";
                }
                else {
                    dayTime.innerText = "白天";
                }
                if (TextBox1.innerText = "") {
                    TextBox1.innerText = "无"
                }
                else { }

        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form  runat="server">
    <div id="body">
        <div name="header" class="header">电信工程系任课教师值班记载表</div>
        <%--时间--%>
        <div name="time" class="time">
            <span id="yearTime"></span>
            <span id="dayTime"></span>
            </div>
        <%--内容--%>
        <div id="content">
            班级：
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="box">
                <asp:ListItem>G1241</asp:ListItem>
                <asp:ListItem>G1242</asp:ListItem>
                <asp:ListItem>G1242</asp:ListItem>
            </asp:DropDownList>
            课时:
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="box">
                <asp:ListItem>第一节课</asp:ListItem>
 <asp:ListItem>第二节课</asp:ListItem>
 <asp:ListItem>第三节课</asp:ListItem>
 <asp:ListItem>第四节课</asp:ListItem>
 <asp:ListItem>第五节课</asp:ListItem>
 <asp:ListItem>第六节课</asp:ListItem>
 <asp:ListItem>第七节课</asp:ListItem>
 <asp:ListItem>第八节课</asp:ListItem>
            </asp:DropDownList>
            系部:
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="box">
                <asp:ListItem>电信工程系</asp:ListItem>
                <asp:ListItem>综合基础部</asp:ListItem>
                <asp:ListItem>机电系</asp:ListItem>
                <asp:ListItem>继续教育部</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            情况:
            <br />
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" CssClass="textBox"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="保存提交" CssClass="btn1" OnClick="Button1_Click" />
        </div>
    </div>
        </form>
</asp:Content>

