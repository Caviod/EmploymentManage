<%@ Page Language="C#" AutoEventWireup="true" CodeFile="enterprisedetail.aspx.cs"
    Inherits="enterprisedetail" %>

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
        <div class="newsdetail2">
            <div class="newsdetail2-1">
                企业详细</div>
            <div class="newsdetail2-2-title">
                <%=ep.EnterpriseId!=0?ep.EnterpriseName:""%></div>
            <div class="enterprisedetail2-2-about">
                <table style="width: 100%; padding-left: 20px; padding-right: 20px;">
                  
                    <tr>
                        <th>
                            企业编号：
                        </th>
                        <td>
                            <%=ep.EnterpriseId!=0?ep.EnterpriseNo:""%>
                        </td>
                        <th>
                            企业行业：
                        </th>
                        <td>
                            <%=ep.EnterpriseId!=0?ep.Industry:""%>
                        </td>
                        <th>
                            企业性质：
                        </th>
                        <td>
                            <%=ep.EnterpriseId != 0 ? ep.Nature : ""%>
                        </td>
                        <th>
                            企业规模：
                        </th>
                        <td>
                            <%=ep.EnterpriseId != 0 ? ep.Sizes : ""%>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            成立时间：
                        </th>
                        <td>
                            <%=ep.EnterpriseId != 0 ? ep.SetUpTime: ""%>
                        </td>
                        <th>
                            注册资金：
                        </th>
                        <td>
                            <%=ep.EnterpriseId != 0 ? ep.Moneys.ToString() : ""%>万
                        </td>
                        <th>
                            址址：
                        </th>
                        <td>
                            <%=ep.EnterpriseId != 0 ? ep.Address : ""%>
                        </td>
                        <th>
                            邮箱：
                        </th>
                        <td>
                            <%=ep.EnterpriseId != 0 ? ep.Email : ""%>
                        </td>
                    </tr>
                </table>
                <div class="blank03">
                </div>
                <table style="width: 100%; padding-left: 20px; padding-right: 20px;">
                    <tr>
                        <th style="text-align: left; padding-left: 20px;">
                            企业简介
                        </th>
                    </tr>
                </table>
            </div>
            <div class="newsdetail2-2-content">
                <%=ep.EnterpriseId != 0 ? ep.Note : ""%>
            </div>
            <div class="enterprisedetail2-2-about">
                <div class="blank02">
                </div>
                <div class="blank02">
                </div>
             <fieldset id="divSend" style="display:none; height:80px; ">
             <legend style="text-align:left;"><a href="#" onclick="document.getElementById('divSend').style.display='none';">关闭</a></legend>
             私信内容：<textarea id="txtContent" runat="server" cols="20" rows="2" style="width:300px; height:60px;"></textarea><asp:Button ID="btnSend"
                 runat="server" Text="发送" OnClientClick="return check()" onclick="btnSend_Click" />
            
             </fieldset>
                <div class="blank02">
                </div>
                <div class="blank02">
                </div>
                <table style="width: 100%; padding-left: 20px; padding-right: 20px;">
                    <tr>
                        <th style="text-align: left; padding-left: 20px;">
                            该企业招聘职位
                        </th>
                    </tr>
                </table>
                <div class="blank03">
                </div>
                <asp:Repeater ID="rpView" runat="server">
                    <HeaderTemplate>
                        <table style="line-height: 30px; width: 100%;">
                            <tr>
                                <th style="width: 40%;">
                                    职位
                                </th>
                                <th style="width: 20%;">
                                    工作地点
                                </th>
                                <th style="width: 15%;">
                                    发布日期
                                </th>
                                <th style="width: 15%;">
                                    截止日期
                                </th>
                                <th style="width: 10%;">
                                    招聘人数
                                </th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td style="text-align: left; padding-left: 20px; color: #ffffff; font-size: 14px;
                                font-weight: bold;">
                                <a href="hiredetail.aspx?id=<%#Eval("HireId")%>" target="_blank">
                                    <%#Eval("Job")%></a>
                            </td>
                            <td>
                                <%#Eval("Address")%>
                            </td>
                            <td>
                                <%# Convert.ToDateTime(Eval("ReleaseTime")).ToString("yyyy-MM-dd")%>
                            </td>
                            <td>
                                <%# Convert.ToDateTime(Eval("CutTime")).ToString("yyyy-MM-dd")%>
                            </td>
                            <td>
                                <%#Eval("HireCount")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                        <div style="height: 30px; line-height: 30px; text-align: center; color: Red;">
                            <asp:Label ID="lblEmpty" Text="暂无信息！" runat="server" Visible='<%#bool.Parse((rpView.Items.Count==0).ToString())%>'>
                            </asp:Label></div>
                    </FooterTemplate>
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
