<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="csy.Index" %>

<!DOCTYPE html>
26
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>校园卡管理系统</title>
    <link rel="stylesheet" type="text/css" href="main.css" /> 
</head>
<body>
    <%--<form id="form1" runat="server">
    <div>
    
    </div>
    </form>--%>
    <audio autoplay="autoplay" preload="auto" src="cyzy.mp3"></audio>
    <div id="top">
        <h1 id="SysHead" runat="server"></h1>
    </div>
    <div id="middle">
        <div id="left">
            <a href="about.html" class="align" target="main">关于校园卡管理系统</a>    
        </div>
        <div id="right">
            <iframe name="main"></iframe>
        </div>
    </div>
</body>
</html>
