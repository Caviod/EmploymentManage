<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatepwds.aspx.cs" Inherits="updatepwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />

    <script language="javascript" type="text/javascript">

        function check() {
            var txtOldPwd = document.getElementById("txtOldPwd");
            var txtNewPwd = document.getElementById("txtNewPwd");
            var txtSureNewPwd = document.getElementById("txtSureNewPwd");
            if (txtOldPwd.value == "") {

                alert("带红色星项不能空！");
                txtOldPwd.focus();
                return false;
            }
            if (txtOldPwd.value != "") {
                if (txtOldPwd.value.length < 6) {
                    alert("密码必须6位或6位以上！");
                    txtOldPwd.focus();
                    return false;
                }
            }
            if (txtNewPwd.value == "") {

                alert("带红色星项不能空！");
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

                alert("带红色星项不能空！");
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
           <%-- <div class="menu-blank" id="menu2" onmousemove="chnage('menu2')" onmouseout="chnage2('menu2')">
                <a href="newslist.aspx">新闻资讯</a></div>--%>
            <div class="menu-blank" id="menu3" onmousemove="chnage('menu3')" onmouseout="chnage2('menu3')">
                <a href="enterpriselist.aspx">企业信息</a></div>
            <div class="menu-blank" id="menu4" onmousemove="chnage('menu4')" onmouseout="chnage2('menu4')">
                <a href="hirelist.aspx">招聘信息</a></div>
            <div class="menu-blank" id="menu5" onmousemove="chnage('menu5')" onmouseout="chnage2('menu5')">
                <a href="registeredenterprise.aspx">企业注册</a></div>
            <div class="menu-blank" id="menu6" onmousemove="chnage('menu6')" onmouseout="chnage2('menu6')">
                学生<a href="registeredusers.aspx">注册</a></div>
           <%-- <div class="menu-blank" id="menu7" onmousemove="chnage('menu7')" onmouseout="chnage2('menu7')">
                <a href="messagelist.aspx">交流区</a></div>--%>
        </div>
        <div class="blank02">
        </div>
        <div class="leftbody">
           
         <div class="leftcenter2">
                <div class="leftcenter2-1" >
                    企业管理中心</div>
                <ul >
                    <li><a href="enterprisecenter.aspx"><span style="padding-left:60px;">查看/修改企业信息</span></a></li>
                    <li><a href="hireadd.aspx"><span style="padding-left:60px;">发布招聘信息</span></a></li>
                    <li><a href="hiremanage.aspx"><span style="padding-left:60px;">招聘信息管理</span></a></li>
<%--                                        <li><a href="userslistall.aspx"><span style="padding-left:60px;">查看所有求职者信息</span></a></li>
                    <li><a href="myenterpriseinfo.aspx"><span style="padding-left:60px;">查看求职者来信</span></a></li>
                    <li><a href="myenterprisesendinfo.aspx"><span style="padding-left:60px;">查看发出私信</span></a></li>--%>
                    <li><a href="updatepwds.aspx"><span style="padding-left:60px;">修改密码</span></a></li>
                    <li><asp:LinkButton ID="lnkbOut" runat="server"  OnClientClick="return confirm('确定要退出吗？')" onclick="lnkbOut_Click"><span style="padding-left:60px;">退出中心</span></asp:LinkButton></li>
                </ul>
            </div>
        </div>
        <div class="rightbody">
            <div class="rightarea2">
                <div class="rightarea2-1">
                    修改密码</div>
               <table style="width: 100%;">
                    
                     
                     <tr>
                        <th>
                            旧密码：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtOldPwd" runat="server" type="password" /><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            新密码：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtNewPwd" runat="server" type="password" /><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                   
                   
                   
                    <tr>
                        <th>
                            确认新密码：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtSureNewPwd" runat="server" type="password" /><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                    
                     
                    <tr>
                        <th>
                            
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:Button ID="bntUpdatePwd" runat="server" Text="修改" 
                               OnClientClick="return check()"  onclick="bntUpdatePwd_Click" />
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
