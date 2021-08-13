<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myenterprisesendinfo.aspx.cs" Inherits="myenterprisesendinfo" %>
<%@ Register Assembly="UcfarPager" Namespace="UcfarPager" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />

  

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
                    查看发出私信</div>
                    
                      <asp:Repeater ID="rpView" runat="server">
                    <HeaderTemplate>
               <table style="line-height: 30px; width: 100%;">
                    <tr>
                        <th>
                            接收人
                        </th>
                        <th>
                            内容
                        </th>
                        <th >
                            发送时间
                        </th>
                         <th >
                            操作
                        </th>
                    </tr>
            </HeaderTemplate>
                    <ItemTemplate>
                    <tr>
                        <td >
                             (<%#BLL.UsersBLL.GetIdByUsers(Convert.ToInt32(Eval("UserId"))).UserName%>)<%#BLL.UsersBLL.GetIdByUsers(Convert.ToInt32(Eval("UserId"))).RealName%></td>
                        <td title=" <%#Eval("InfoContent")%>">
                             <%#Eval("InfoContent").ToString().Length > 16 ? Eval("InfoContent").ToString().Substring(0, 15) + "..." : Eval("InfoContent").ToString()%>
                        </td>
                        <td>
                              <%#Eval("InfoTime")%>
                        </td>
                        <td>
                              <a href="myenterpriseinfodetail.aspx?id=<%#Eval("InfoId")%>">查看详细</a>
                        </td>
                    </tr>
                  
               </ItemTemplate>
                   <FooterTemplate></table>
                    <div style="height:30px; line-height:30px; text-align:center; color:Red;">
          <asp:Label ID="lblEmpty" Text="暂无信息！"  runat="server" Visible='<%#bool.Parse((rpView.Items.Count==0).ToString())%>'>
</asp:Label></div>
                   </FooterTemplate>
                
                </asp:Repeater>
                
                
            </div>
            <div style=" height:30px; line-height:30px">
             <cc1:UcfarPager ID="UcfarPager1" runat="Server" 
            PageSize="10" NavigatePreviousText="上一页" NavigateNextText="下一页" MainTableStyle="text-align:center;"
            LeftPageNumberBoxPadding="2px 5px 2px 5px" DisplayPagerNum="5" PageLinkForeColor="#0099FF"
            PageLinkHoverBackColor="#0099FF" PageLinkSelectedBackColor="#0099FF" PageLinkSelectedBorderColor="#0099FF"
            PageNumberBoxBorderColor="#0099FF" PageNumberHoverBorderColor="#0099FF"  onpagechanged="UcfarPager1_PageChanged" >
        </cc1:UcfarPager>
            </div>
        </div>
    </div>
    <div class="bodybottom">
        毕业设计-大学生就业信息管理系统&nbsp;&nbsp;
        管理系统&nbsp;&nbsp;
        <br />
        201710320081&nbsp;陈云帆&nbsp;通信172<a href="admin/Login.aspx" target="_blank">后台管理入口</a>
    </div>
    </form>
</body>
</html>
