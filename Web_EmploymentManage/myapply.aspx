<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myapply.aspx.cs" Inherits="myapply" %>
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
           <%-- <div class="menu-blank" id="menu7" onmousemove="chnage('menu7')" onmouseout="chnage2('menu7')">
                <a href="messagelist.aspx">交流区</a></div>--%>
        </div>
        <div class="blank02">
        </div>
        <div class="leftbody">
           
            <div class="leftcenter2">
                <div class="leftcenter2-1" >
                    个人中心</div>
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
                    查看已申请过的职位</div>
                      <asp:Repeater ID="rpView" runat="server">
                    <HeaderTemplate>
               <table style="line-height: 30px; width: 100%;">
                    <tr>
                     <th style="width: 10%;">
                            申请时间
                        </th>
                        <th style="width: 20%;">
                            职位
                        </th>
                        <th style="width: 28%;">
                            企业名称
                        </th>
                        <th style="width: 20%;">
                            工作地点
                        </th>
                        <th style="width: 10%;">
                            发布日期
                        </th>
                         <th style="width: 12%;">
                            职位投递情况
                        </th>
                    </tr>
           </HeaderTemplate>
                    <ItemTemplate>
                    <tr>
                    <td>
                            <%#Convert.ToDateTime(Eval("ApplyTime")).ToString("yyyy-MM-dd HH:mm")%>
                        </td>
                        <td style="text-align: left; padding-left: 20px; color: #1974c5; font-size: 14px;
                            font-weight: bold;">
                            <a href="hiredetail.aspx?id=<%#Eval("HireId")%>" target="_blank"><%#BLL.HireBLL.GetIdByHire(Convert.ToInt32(Eval("HireId"))).Job%></a>
                        </td>
                        <td style="text-align: left; padding-left: 20px; color: #1974c5;">
                            <a href="enterprisedetail.aspx?id=<%#BLL.HireBLL.GetIdByHire(Convert.ToInt32(Eval("HireId"))).EnterpriseId%>" target="_blank"><%#BLL.EnterpriseBLL.GetIdByEnterprise(BLL.HireBLL.GetIdByHire(Convert.ToInt32(Eval("HireId"))).EnterpriseId).EnterpriseName%></a>
                        </td>
                        <td>
                            <%#BLL.HireBLL.GetIdByHire(Convert.ToInt32(Eval("HireId"))).Address%>
                        </td>
                        <td>
                            <%#BLL.HireBLL.GetIdByHire(Convert.ToInt32(Eval("HireId"))).ReleaseTime.ToString("yyyy-MM-dd")%>
                        </td>
                         <td  style='<%#Eval("State").ToString()=="已确认"?"color:Red;":"color:Black;"%>'>
                          <%#Eval("State")%>
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
            PageNumberBoxBorderColor="#0099FF" PageNumberHoverBorderColor="#0099FF"   onpagechanged="UcfarPager1_PageChanged">
        </cc1:UcfarPager>
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