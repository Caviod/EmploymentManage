<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myusersinfodetail.aspx.cs"
    Inherits="myusersinfodetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">

        function check() {

            var txtContent = document.getElementById("txtContent");



            if (txtContent.value == "") {
                alert("私信内容不能为空！");
                txtContent.focus();
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
                    求职者个人中心</div>
                <ul >
                    <li><a href="userscenter.aspx"><span style="padding-left:60px;">查看/修改个人信息</span></a></li>
                    <li><a href="myapply.aspx"><span style="padding-left:60px;">查看已申请过的职位</span></a></li>
<%--                    <li><a href="myusersinfo.aspx"><span style="padding-left:60px;">查看企业来信</span></a></li>
                    <li><a href="myuserssendinfo.aspx"><span style="padding-left:60px;">查看发出私信</span></a></li>--%>
                    <li><a href="updatepwd.aspx"><span style="padding-left:60px;">修改密码</span></a></li>
                    <li><asp:LinkButton ID="lnkbOut" runat="server" OnClientClick="return confirm('确定要退出吗？')" onclick="lnkbOut_Click"><span style="padding-left:60px;">退出中心</span></asp:LinkButton></li>
                </ul>
            </div>
        </div>
        <div class="rightbody">
            <div class="rightarea2">
                <div class="rightarea2-1">
                    私信对话详细</div>
                <table style="width: 100%;">
                    <tr>
                        <td style="text-align: left; padding-left: 20px; padding-right: 20px;">
                            <span style="float: left; font-weight: bold;">(<%=model.InfoType == 1 ? BLL.EnterpriseBLL.GetIdByEnterprise(model.EnterpriseId).UserName : BLL.UsersBLL.GetIdByUsers(model.UserId).UserName%>)<%=model.InfoType == 1 ? BLL.EnterpriseBLL.GetIdByEnterprise(model.EnterpriseId).EnterpriseName : BLL.UsersBLL.GetIdByUsers(model.UserId).RealName%></span><span
                                style="float: right;"><%=model.InfoTime%></span>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left; padding-left: 20px; padding-right: 20px; line-height: 20px;
                            vertical-align: text-top;">
                            <%=model.InfoContent%>
                        </td>
                    </tr>
                </table>
                <asp:Repeater ID="rpView" runat="server">
                    <ItemTemplate>
                        <table style="width: 100%;">
                            <tr>
                                <td style="text-align: left; padding-left: 20px; padding-right: 20px;">
                                    <span style="float: left; font-weight: bold;">(<%#Eval("FollowType").ToString() == "0" ? BLL.UsersBLL.GetIdByUsers(Convert.ToInt32(Eval("FollowId"))).UserName : BLL.EnterpriseBLL.GetIdByEnterprise(Convert.ToInt32(Eval("FollowId"))).UserName%>)<%#Eval("FollowType").ToString() == "0" ? BLL.UsersBLL.GetIdByUsers(Convert.ToInt32(Eval("FollowId"))).RealName : BLL.EnterpriseBLL.GetIdByEnterprise(Convert.ToInt32(Eval("FollowId"))).EnterpriseName%></span><span
                                        style="float: right;"><%#Eval("FollowTime")%></span>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: left; padding-left: 20px; padding-right: 20px; line-height: 20px;
                                    vertical-align: text-top;">
                                    <%#Eval("FollowContent")%>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:Repeater>
                <table style="width: 100%;">
                    <tr>
                        <th>
                            私信内容
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <textarea id="txtContent" runat="server" cols="20" style="width: 300px; height: 50px;"
                                rows="2"></textarea>
                        </td>
                    </tr>
                    <tr>
                        <th>
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <asp:Button ID="btnSend" runat="server" Text="发送" OnClientClick="return check()"
                                OnClick="btnSend_Click" />&nbsp;<input id="BtnBackProList" type="button" value="返回"
                                    oncl
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="bodybottom">
        毕业设计-大学生就业信息管理系统&nbsp;&nbsp;
        -大学生就业信息管理系统&nbsp;&nbsp;
        <br />
        201710320081&nbsp;陈云帆&nbsp;通信172<a href="admin/Login.aspx" target="_blank">后台管理入口</a>
    </div>
    </form>
</body>
</html>
