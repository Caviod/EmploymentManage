<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Top.aspx.cs" Inherits="admin_Top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>主页头部</title>
    <link href="css/Base.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="TopBack">
        <div class="TopMes">
            欢迎您：<font color="red"><%=adminName%></font>&nbsp;&nbsp; <a href="UpdatePwd.aspx" target="main"
                style="color: #fff;">[修改密码]</a>&nbsp;&nbsp;
            <a href="../index.aspx"target="_blank" style="color: #fff;">[预览前台]</a>&nbsp;&nbsp;
            <asp:LinkButton ID="LBQuit" runat="server" Font-Bold="True" ForeColor="White" OnClick="LBQuit_Click"
                OnClientClick='return confirm("你确定退出管理系统吗？") '>[退出管理]</asp:LinkButton>
        </div>
      
    </div>
    </form>
</body>
</html>