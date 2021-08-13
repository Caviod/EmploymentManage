<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />
 <script>
          function prompt() {
              alert('请将您当时注册的用户名或姓名或身份证或联系手机等相关信息发送Email到admin@admin.com,我们后台系统会及时帮您查询找回密码，请留意您的邮箱信息！');
              return false;
          }


      </script>
    <script language="javascript" type="text/javascript">

    function check() {

        var txtUserName = document.getElementById("txtUserName");
        var txtPwd = document.getElementById("txtPwd");


        if (txtUserName.value == "") {
            alert("用户名不能为空！");
            txtUserName.focus();
            return false;
        }
        else if (txtPwd.value == "") {
            alert("密码不能为空！");
            txtPwd.focus();
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
            <!--<div class="menu-blank" id="menu2" onmousemove="chnage('menu2')" onmouseout="chnage2('menu2')">-->
                <!--<a href="newslist.aspx">新闻资讯</a></div>-->
            <div class="menu-blank" id="menu3" onmousemove="chnage('menu3')" onmouseout="chnage2('menu3')">
                <a href="enterpriselist.aspx">企业信息</a></div>
            <div class="menu-blank" id="menu4" onmousemove="chnage('menu4')" onmouseout="chnage2('menu4')">
                <a href="hirelist.aspx">招聘信息</a></div>
            <div class="menu-blank" id="menu5" onmousemove="chnage('menu5')" onmouseout="chnage2('menu5')">
                <a href="registeredenterprise.aspx">企业注册</a></div>
            <div class="menu-blank" id="menu6" onmousemove="chnage('menu6')" onmouseout="chnage2('menu6')">
                学生<a href="registeredusers.aspx">注册</a></div>
            <!--<div class="menu-blank" id="menu7" onmousemove="chnage('menu7')" onmouseout="chnage2('menu7')">-->
                <!--<a href="messagelist.aspx">交流区</a></div>-->
        </div>
        <div class="blank02">
        </div>
        <div class="leftbody">
        <div class="leftarea3">
                <div class="leftarea3-1">
                    登录</div>
                <table id="tbLogin" runat="server" style="display: block;">
                    <tr>
                        <td style="width: 80px; height: 30px; line-height: 30px;">
                            用户名：
                        </td>
                        <td style="width: 148px; height: 30px; line-height: 30px;">
                            <input id="txtUserName" runat="server" style="width: 100px" type="text" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 80px; height: 30px; line-height: 30px;">
                            密&nbsp;&nbsp;码：
                        </td>
                        <td style="width: 148px; height: 30px; line-height: 30px;">
                            <input id="txtPwd" runat="server" style="width: 100px" type="password" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 80px; height: 30px; line-height: 30px;">
                       
                        </td>
                        <td style="width: 148px; height: 30px; line-height: 30px;">
                            <input id="rdoUsers" runat="server" name="aa" checked="true" type="radio" />学生
                            <input id="rdoEnterprise" type="radio" runat="server" name="aa" />企业
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 80px; height: 30px; line-height: 30px;">
                        <asp:LinkButton
                ID="lnkbForget" runat="server" OnClientClick='return prompt()'>忘记密码？</asp:LinkButton>
                        </td>
                        <td style="width: 148px; height: 30px; line-height: 30px;">
                            <asp:Button ID="btnLogin" runat="server" Text="登录" OnClientClick="return check()"
                                OnClick="btnLogin_Click" />&nbsp;<input id="Reset1" type="reset" value="重置" />
                        </td>
                    </tr>
                </table>
                <table id="tbUsers" style="display: none;" runat="server">
                    <tr>
                        <td style="width: 228px; height: 100px; line-height: 100px;">
                            你好，<a id="aUsers" runat="server"></a>&nbsp;您是：学生&nbsp;<asp:LinkButton ID="lnkbUsersOut"
                                runat="server" OnClick="lnkbUsersOut_Click" ForeColor="#3a3a3a">退出</asp:LinkButton>
                        </td>
                    </tr>
                </table>
                <table id="tbEnterprise" style="display: none;" runat="server">
                    <tr>
                        <td style="width: 228px; height: 100px; line-height: 100px;">
                            你好，<a id="aEnterprise" runat="server"></a>&nbsp;您是：企业&nbsp;<asp:LinkButton ID="lnkbEnterpriseOut"
                                runat="server" OnClick="lnkbEnterpriseOut_Click" ForeColor="#3a3a3a">退出</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </div>
            
            <div class="blank02">
            </div>
            <div class="leftarea2">
                <div class="leftarea2-1">
                    动态新闻</div>
                <ul>
                   <%if (listTop10.Count != 0)
                      {
                          for (int i = 0; i < listTop10.Count; i++)
                          { 
                    %>
                    <li>&nbsp;<a href="newsdetail.aspx?id=<%=listTop10[i].NewsId%>" target="_blank" title="<%=listTop10[i].NewsTitle%>"><%=listTop10[i].NewsTitle.Length > 18 ? listTop10[i].NewsTitle.Substring(0, 18) : listTop10[i].NewsTitle%></a></li>
                    <%
                        }
                  }
                    %>
                </ul>
            </div>
        </div>
        <div class="rightbody">
            <div class="rightarea2">
                <div class="rightarea2-1">最新岗位</div>
                <asp:Repeater ID="rpView" runat="server">
                    <HeaderTemplate>
                        <table style="line-height: 30px; width: 100%;">
                            <tr>
                                <th style="width: 30%;">
                                    职位
                                </th>
                                <th style="width: 35%;">
                                    企业名称
                                </th>
                                <th style="width: 20%;">
                                    工作地点
                                </th>
                                <th style="width: 15%;">
                                    发布日期
                                </th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td style="text-align: left; padding-left: 20px; color: #1974c5; font-size: 14px;
                                font-weight: bold;">
                                <a href="hiredetail.aspx?id=<%#Eval("HireId")%>" target="_blank">
                                    <%#Eval("Job")%></a>
                            </td>
                            <td style="text-align: left; padding-left: 20px; color: #1974c5;">
                                <a href="enterprisedetail.aspx?id=<%#Eval("EnterpriseId")%>"  target="_blank">
                                    <%#BLL.EnterpriseBLL.GetIdByEnterprise(Convert.ToInt32(Eval("EnterpriseId"))).EnterpriseName%></a>
                            </td>
                            <td>
                                <%#Eval("Address")%>
                            </td>
                            <td>
                                <%# Convert.ToDateTime(Eval("ReleaseTime")).ToString("yyyy-MM-dd")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table></FooterTemplate>
                </asp:Repeater>
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
