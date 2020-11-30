﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="csy.StudentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="phStudents" runat="server"></asp:PlaceHolder>
            <asp:Button ID="btnNew" runat="server" Text="新增" OnClick="btnNew_Click" />
            <asp:Button ID="btnModify" runat="server" Text="修改" />
            <asp:Button ID="btnDelete" runat="server" Text="删除" />
        </div>
    </form>
</body>
</html>
