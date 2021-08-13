<%@ Page Language="C#" AutoEventWireup="true" CodeFile="usersdetail.aspx.cs" Inherits="usersdetail" %>

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

    <script language="javascript" type="text/javascript">
          function $(o) { return document.getElementById(o); }
          function CheckImgCss(o, img) {
              if (!/\.((jpg)|(bmp)|(gif)|(png))$/ig.test(o.value)) {
                  alert('只能上传jpg,bmp,gif,png格式图片!');
                  o.outerHTML = o.outerHTML;
              }
              else {

                  $(img).filters.item("DXImageTransform.Microsoft.AlphaImageLoader").src = o.value;
                  //$('Image1').src = o.value;//这里IE7已经不支持了。所以才有上面的方法。

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
          <%--  <div class="menu-blank" id="menu2" onmousemove="chnage('menu2')" onmouseout="chnage2('menu2')">
                <a href="newslist.aspx">新闻资讯</a></div>--%>
            <div class="menu-blank" id="menu3" onmousemove="chnage('menu3')" onmouseout="chnage2('menu3')">
                <a href="enterpriselist.aspx">企业信息</a></div>
            <div class="menu-blank" id="menu4" onmousemove="chnage('menu4')" onmouseout="chnage2('menu4')">
                <a href="hirelist.aspx">招聘信息</a></div>
            <div class="menu-blank" id="menu5" onmousemove="chnage('menu5')" onmouseout="chnage2('menu5')">
                <a href="registeredenterprise.aspx">企业注册</a></div>
            <div class="menu-blank" id="menu6" onmousemove="chnage('menu6')" onmouseout="chnage2('menu6')">
                学生<a href="registeredusers.aspx">注册</a></div>
          <%--  <div class="menu-blank" id="menu7" onmousemove="chnage('menu7')" onmouseout="chnage2('menu7')">
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
<%--                               <li><a href="userslistall.aspx"><span style="padding-left:60px;">查看所有求职者信息</span></a></li>
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
                    个人详细信息</div>
                <table style="width: 100%;">
                    <tr>
                        <th style="width: 20%;">
                            姓名：
                        </th>
                        <td style="text-align: left; padding-left: 20px;" style="width: 80%; "">
                            <%=model.RealName%>
                        </td>
                    </tr>
                    <%--<tr>
                        <th>
                            头像：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <img src="<%=model.HeadImg%>" style="width: 100px; height: 120px;" />
                        </td>
                    </tr>--%>
                    <tr>
                        <th>
                            性别：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.Sex%>
                        </td>
                    </tr>
                  <%--  <tr>
                        <th>
                            身份证：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.IdCard%>
                        </td>
                    </tr>--%>
                    <%-- <tr>
                        <th>
                            贯籍：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                           <%=model.Penetration%>
                        </td>
                    </tr>--%>
                     <tr>
                        <th>
                            出生日期：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                           <%=model.Birth.ToString("yyyy-MM-dd")%>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            年龄：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.Age%>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            政治背景：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.Political%>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            工作经验：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                           <%=model.Experience%>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            学历：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.Education%>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            专业：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.Major%>
                        </td>
                    </tr>
                   <%-- <tr>
                        <th>
                            毕业院校：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.Colleges%>
                        </td>
                    </tr>--%>
                    <tr>
                        <th>
                            毕业时间：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.GraduationTime %>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            是否就业：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.IsEmployment%>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            联系手机：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.Phone%>
                        </td>
                    </tr>
                    <%--<tr>
                        <th>
                            邮箱：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.Email%>
                        </td>
                    </tr>--%>
                <%--    <tr>
                        <th>
                            日前所在地：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                           <%=model.Address%>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            技能介绍：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <%=model.Introduce%>
                        </td>
                    </tr>
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
                                OnClick="btnSend_Click" />&nbsp;
                            <asp:Button ID="btnReturn" runat="server" Text="返回" OnClick="btnReturn_Click" />
                        </td>
                    </tr>--%>
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
