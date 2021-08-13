<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registeredusers.aspx.cs" Inherits="registeredusers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />

 
<script language="javascript" type="text/javascript">

    function check() {
        var txtUserName = document.getElementById("txtUserName");


        var txtNewPwd = document.getElementById("txtNewPwd");
        var txtSureNewPwd = document.getElementById("txtSureNewPwd");

        var txtRealName = document.getElementById("txtRealName");
       
        if (txtUserName.value == "") {

            alert("带红色 * 号项不能为空！");
            txtUserName.focus();
            return false;
        }
        if (txtNewPwd.value == "") {

            alert("带红色 * 号项不能为空！");
            txtNewPwd.focus();
            return false;
        }
        if (txtNewPwd.value != "") {
            if (txtNewPwd.value.length < 6) {
                alert("密码必须6位或6位以上！");
                txtNewPwd.focus();
                return false;
            }
        }
        if (txtSureNewPwd.value == "") {

            alert("带红色 * 号项不能为空！");
            txtSureNewPwd.focus();
            return false;
        }
        if (txtSureNewPwd.value != "") {
            if (txtSureNewPwd.value.length < 6) {
                alert("密码必须6位或6位以上！");
                txtSureNewPwd.focus();
                return false;
            }
        }
        if (txtNewPwd.value != txtSureNewPwd.value) {

            alert("两次密码不一致！");
            txtSureNewPwd.focus();
            return false;
        }
        if (txtRealName.value == "") {

            alert("带红色 * 号项不能为空！");
            txtRealName.focus();
            return false;
        }
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="bg">
        <div class="head">
        </div>

        <script language="javascript" type="text/javascript">
            function chnage(typeId) {
                document.getElementById(typeId).className = "menu-blank2";

            }
            function chnage2(typeId) {
                document.getElementById(typeId).className = "menu-blank";

            }
    
        </script>

        <div class="menu">
            <div class="menu-blank" id="menu1" onmousemove="chnage('menu1')" onmouseout="chnage2('menu1')">
                <a href="index.aspx">首页</a></div>
            <%--<div class="menu-blank" id="menu2" onmousemove="chnage('menu2')" onmouseout="chnage2('menu2')">
                <a href="newslist.aspx">新闻资讯</a></div>--%>
            <div class="menu-blank" id="menu3" onmousemove="chnage('menu3')" onmouseout="chnage2('menu3')">
                <a href="enterpriselist.aspx">企业信息</a></div>
            <div class="menu-blank" id="menu4" onmousemove="chnage('menu4')" onmouseout="chnage2('menu4')">
                <a href="hirelist.aspx">招聘信息</a></div>
            <div class="menu-blank" id="menu5" onmousemove="chnage('menu5')" onmouseout="chnage2('menu5')">
                <a href="registeredenterprise.aspx">企业注册</a></div>
            <div class="menu-blank" id="menu6" onmousemove="chnage('menu6')" onmouseout="chnage2('menu6')">
                学生<a href="registeredusers.aspx">注册</a></div>
            <%--<div class="menu-blank" id="menu7" onmousemove="chnage('menu7')" onmouseout="chnage2('menu7')">
                <a href="messagelist.aspx">交流区</a></div>--%>
        </div>
        <div class="blank02">
        </div>
        <div class="newsdetail2">
            <div class="newsdetail2-1">
                学生注册</div>
                <div class="blank02"></div>
            <div class="enterprisedetail2-2-about">
                <table style="width: 100%; padding-left: 20px; padding-right: 20px;">
                    <tr>
                        <th>
                            账号：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtUserName" runat="server" type="text" style="width:200px;" /><span  style="color:Red;">* 账号注册后不可更改</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            密码：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtNewPwd" runat="server" type="password" style="width:200px;"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            确认密码：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtSureNewPwd" runat="server" type="password" style="width:200px;"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            姓名：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtRealName" runat="server" type="text" style="width:200px;"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     
                    <tr>
                        <th>
                            性别：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:DropDownList ID="ddlSex" runat="server">
                                <asp:ListItem>男</asp:ListItem>
                                <asp:ListItem>女</asp:ListItem>
                               
                            </asp:DropDownList>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            学历：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:DropDownList ID="ddlEducation" runat="server">
                                <asp:ListItem>高中</asp:ListItem>
                                <asp:ListItem>中技</asp:ListItem>
                                <asp:ListItem>中专</asp:ListItem>
                                <asp:ListItem>大专</asp:ListItem>
                                <asp:ListItem Selected="True">本科</asp:ListItem>
                                <asp:ListItem>硕士</asp:ListItem>
                                <asp:ListItem>博士</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                              <asp:Button ID="btnAdd" runat="server" Text="注册" OnClientClick="return check()" onclick="btnAdd_Click" />&nbsp;<input id="Reset1" type="reset"
                                value="重置" />
                        </td>
                    </tr>
                </table>
            </div>
            
            
        </div>
    </div>
    <div class="bodybottom">
        毕业设计-大学生就业信息管理系统&nbsp;&nbsp;
        <br />
        201710320081&nbsp;陈云帆&nbsp;通信172<a href="admin/Login.aspx" target="_blank">后台管理入口</a>
    </div>
    </form>
</body>
</html>