<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentNew.aspx.cs" Inherits="csy.StudentNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="mainform" action="StudentPage.aspx" method="post">
        <fieldset>
            <legend>用户注册</legend>
            <label for="ucode">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;学号:</label>
            <input type="text" id="ucode"/>
            <br />
            <label for="fname">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;姓名:</label>
            <input type="text" id="fname"/>
            <br />
            <input type="submit" value="确认"" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="reset" value="重置" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </fieldset>
    </form>
</body>
</html>
