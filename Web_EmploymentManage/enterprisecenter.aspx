<%@ Page Language="C#" AutoEventWireup="true" CodeFile="enterprisecenter.aspx.cs" Inherits="enterprisecenter" ValidateRequest="false" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />

    <script src="admin/JavaScript/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
 <link href="admin/kindeditor/themes/default/default.css" rel="stylesheet" type="text/css" />

    <link href="admin/kindeditor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />
    <%--  --%>
    <script src="admin/kindeditor/kindeditor.js" type="text/javascript"></script>


    <script src="admin/kindeditor/lang/zh_CN.js" type="text/javascript"></script>

    <script src="admin/kindeditor/plugins/code/prettify.js" type="text/javascript"></script>
<script>
    KindEditor.ready(function(K) {
        var editor1 = K.create('#myEditor', {
        cssPath: 'admin/kindeditor/plugins/code/prettify.css',
        uploadJson: 'admin/kindeditor/upload_json.ashx',
        fileManagerJson: 'admin/kindeditor/file_manager_json.ashx',
            allowFileManager: true,
            afterCreate: function() {
                var self = this;
                K.ctrl(document, 13, function() {
                    self.sync();
                    K('form[name=example]')[0].submit();
                });
                K.ctrl(self.edit.doc, 13, function() {
                    self.sync();
                    K('form[name=example]')[0].submit();
                });
            },
            afterBlur: function() { this.sync(); }
        });
        prettyPrint();
    });
    </script>
    
      <script language="javascript" type="text/javascript">

          function check() {

              var txtEnterpriseNo = document.getElementById("txtEnterpriseNo");
              var txtEnterpriseName = document.getElementById("txtEnterpriseName");
              var txtSetUpTime = document.getElementById("txtSetUpTime");

              var txtMoneys = document.getElementById("txtMoneys");
              var txtEmail = document.getElementById("txtEmail");
              var txtAddress = document.getElementById("txtAddress");

              if (txtEnterpriseNo.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtEnterpriseNo.focus();
                  return false;
              }
              if (txtEnterpriseName.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtEnterpriseName.focus();
                  return false;
              }
              if (txtSetUpTime.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtSetUpTime.focus();
                  return false;
              }
              if (txtMoneys.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtMoneys.focus();
                  return false;
              }

             
              if (txtEmail.value != "") {

                  if (txtEmail.value.search(/^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$/) == -1) {
                      alert("请输入正确的Email格式！");
                      txtEmail.focus();
                      return false;
                  }

              }
              else {
                  alert("带红色 * 号项不能为空！");
                  txtEmail.focus();
                  return false;

              }

              if (txtAddress.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtAddress.focus();
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
        <div class="leftbody">
           
             <div class="leftcenter2">
                <div class="leftcenter2-1" >
                    企业管理中心</div>
                <ul >
                    <li><a href="enterprisecenter.aspx"><span style="padding-left:60px;">查看/修改企业信息</span></a></li>
                    <li><a href="hireadd.aspx"><span style="padding-left:60px;">发布招聘信息</span></a></li>
                    <li><a href="hiremanage.aspx"><span style="padding-left:60px;">招聘信息管理</span></a></li>
<%--                    <li><a href="userslistall.aspx"><span style="padding-left:60px;">查看所有求职者信息</span></a></li>
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
                    查看/修改企业信息</div>
               <table style="width: 100%;">
                    <tr>
                        <th style="width: 20%;">
                            账号：
                        </th>
                        <td style="text-align:left; padding-left:20px; width: 80%;">
                            <asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                     
                     <tr>
                        <th>
                            企业编号：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtEnterpriseNo" runat="server" type="text" style="width:150px;" /><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     
                    
                     <tr>
                        <th>
                            企业名称：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtEnterpriseName" runat="server" type="text" style="width:200px;"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                    
                     <tr>
                        <th>
                            企业行业：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                           <asp:DropDownList ID="ddlIndustry" runat="server">
                                <asp:ListItem Selected="True">计算机/互联网/通信/电子</asp:ListItem>
                                <asp:ListItem>会计/金融/银行/保险</asp:ListItem>
                                <asp:ListItem>贸易/消费/制造/营运</asp:ListItem>
                                <asp:ListItem>制药/医疗</asp:ListItem>
                                <asp:ListItem>计算机/互联网/通信/电子</asp:ListItem>
                                <asp:ListItem>广告/媒体</asp:ListItem>
                                <asp:ListItem>房地产/建筑</asp:ListItem>
                                <asp:ListItem>专业服务/教育/培训</asp:ListItem>
                                <asp:ListItem>服务业</asp:ListItem>
                                <asp:ListItem>物流/运输</asp:ListItem>
                                <asp:ListItem>能源/原材料</asp:ListItem>
                                <asp:ListItem>政府/非赢利机构/其它</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            企业性质：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:DropDownList ID="ddlNature" runat="server">
                            
<%--                            <asp:ListItem>外资(欧美)</asp:ListItem>
                                <asp:ListItem>外资(非欧美)</asp:ListItem>
                                <asp:ListItem>合资(欧美)</asp:ListItem>
                                <asp:ListItem>合资(非欧美)</asp:ListItem>
                                <asp:ListItem>国企</asp:ListItem>--%>
                                <asp:ListItem Selected="True">民营公司</asp:ListItem>
                                <asp:ListItem>外企代表处</asp:ListItem>
                                <asp:ListItem>政府机关</asp:ListItem>
                                <asp:ListItem>事业单位</asp:ListItem>
                                <asp:ListItem>非盈利机构</asp:ListItem>
                                <asp:ListItem>其它性质</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                     
                     <tr>
                        <th>
                            企业规模：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                           <asp:DropDownList ID="ddlSizes" runat="server">
                             <asp:ListItem>50人以下</asp:ListItem>
                            <asp:ListItem Selected="True">50-150人</asp:ListItem>
                                <asp:ListItem>150-500人</asp:ListItem>
                                <asp:ListItem>500-1000人</asp:ListItem>
                                <asp:ListItem>10000人以上</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            成立时间：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtSetUpTime" runat="server" type="text" onfocus="WdatePicker({dateFmt:'yyyy-MM'})"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            注册资金：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtMoneys" runat="server" type="text" onkeyup="this.value=this.value.replace(/\D/g,'')"  onafterpaste="this.value=this.value.replace(/\D/g,'')"/>万<span  style="color:Red;">* 只能输入数字</span>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            邮箱：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtEmail" runat="server" type="text" /><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            址址：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtAddress" runat="server" type="text" style="width:300px;" /><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            企业简介：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                       <textarea id="myEditor" name="myEditor" runat="server" style=" width:99%; height:300px;"></textarea>
                        </td>
                    </tr>
                     
                    <tr>
                        <th>
                            
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:Button ID="btnUpdate" runat="server" Text="修改" OnClientClick="return check()" onclick="btnUpdate_Click" />
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