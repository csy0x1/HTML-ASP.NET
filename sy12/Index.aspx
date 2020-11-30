<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="csy.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
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
            <div id="fnav" onclick="document.getElementById('snav').style.display='block';">
                <a><p>关于我们</p></a>
            </div>
            <div id="snav" onclick="document.getElementById('snav').style.display='none';">
                <a href="about.html#prj" target="main">项目介绍</a>
                <a href="about.html#yueguanli" target="main">余额管理</a>
                <a href="about.html#other" target="main">其他功能</a>
                <a href="about.html#developer" target="main">成员介绍</a>
            </div>
            <div id="bmnav" onclick="document.getElementById('sbmnav').style.display='block';">
                <a><p>基本信息管理</p></a>
            </div>
            <div id="sbmnav" onclick="document.getElementById('sbmnav').style.display='none';">
                <a href="StudentPage.aspx" target="main">学生管理</a>
            	<a href="TestCardPage.aspx" target="main">校园卡管理</a>
            </div>
        </div>
        <div id="right">
            <iframe name="main"></iframe>
        </div>
    </div>
    <div id="tail">
        <input type="hidden" id="log" runat="server"/>
    </div>
</body>
</html>
