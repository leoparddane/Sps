<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Style/Style.css" rel="stylesheet" />
</head>
<body>
    <form class="indexLogin">

    <input type="text" name="name"title="用户名"required ="required " placeholder="用户名"class="indexLogin_input indexLogin_input_mag "autofocus ="autofocus " /><br />
    <input type="password" name="password"required ="required " title="密码" placeholder="密码"class="indexLogin_input" />
        <input type="submit" value="登录" title="登录"class="indexLogin_input indexLogin_input_go" />
    </form>
</body>
</html>
