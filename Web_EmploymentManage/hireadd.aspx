<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hireadd.aspx.cs" Inherits="hireadd" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />

    <script src="admin/JavaScript/My97DatePicker/WdatePicker.js" type="text/javascript"></script>

    



 <link href="admin/kindeditor/themes/default/default.css" rel="stylesheet" type="text/css" />

    <link href="admin/kindeditor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />

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
    <script>
        KindEditor.ready(function(K) {
            var editor1 = K.create('#myEditor2', {
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

              var txtJob = document.getElementById("txtJob");
              
              var txtHireCount = document.getElementById("txtHireCount");
             

              var txtAddress = document.getElementById("txtAddress");

              var myEditor = document.getElementById("myEditor");
              var myEditor2 = document.getElementById("myEditor2");

              var txtReleaseTime = document.getElementById("txtReleaseTime");
              var txtCutTime = document.getElementById("txtCutTime");


              if (txtJob.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtJob.focus();
                  return false;
              }

              if (txtHireCount.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtHireCount.focus();
                  return false;
              }
             

             
              
              if (txtAddress.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtAddress.focus();
                  return false;
              }
              if (myEditor.value == "") {
                  alert("职位描述不能为空！");
                  return false;
              }
              if (myEditor2.value == "") {
                  alert("任职条件不能为空！");
                  return false;
              }

              if (txtReleaseTime.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtReleaseTime.focus();
                  return false;
              }
              if (txtCutTime.value == "") {
                  alert("带红色 * 号项不能为空！");
                  txtCutTime.focus();
                  return false;
              }
              if (txtCutTime.value <= txtReleaseTime.value) {

                  alert("截止日期必需大于发布日期！");
                  txtCutTime.focus();
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
                    <%=dh%></div>
               <table style="width: 100%;">
                    <tr>
                        <th style="width: 20%;">
                            职位名称：
                        </th>
                        <td style="text-align:left; padding-left:20px; width: 80%;">
                            <input id="txtJob" runat="server" type="text" style="width:150px;" /><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            工作类型：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                           <asp:DropDownList ID="ddlJobType" runat="server">
                                <asp:ListItem Selected="True">全职</asp:ListItem>
                                <asp:ListItem>兼职</asp:ListItem>
                             
                            </asp:DropDownList>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            招聘人数：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtHireCount" runat="server" type="text" style="width:150px;" /><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     
                    
                     
                    
                     <tr>
                        <th>
                            年龄要求：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                           <asp:DropDownList ID="ddlAge" runat="server">
                                <asp:ListItem>不限</asp:ListItem>
                                <asp:ListItem Selected="True">18-30岁</asp:ListItem>
                                <asp:ListItem>18-35岁</asp:ListItem>
                                <asp:ListItem>18-40岁</asp:ListItem>
                                <asp:ListItem>18-45岁</asp:ListItem>
                                <asp:ListItem>18-50岁</asp:ListItem>
                                <asp:ListItem>18-55岁</asp:ListItem>
                               
                            </asp:DropDownList>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            性别要求：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:DropDownList ID="ddlSex" runat="server">
                            
                            <asp:ListItem Selected="True">不限</asp:ListItem>
                                <asp:ListItem>男</asp:ListItem>
                                <asp:ListItem>女</asp:ListItem>
                               
                            </asp:DropDownList>
                        </td>
                    </tr>
                     
                     <tr>
                        <th>
                            学历要求：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:DropDownList ID="ddlEducation" runat="server">
                                 <asp:ListItem Selected="True">不限</asp:ListItem>
                                <asp:ListItem>高中</asp:ListItem>
                                <asp:ListItem>中技</asp:ListItem>
                                <asp:ListItem>中专</asp:ListItem>
                                <asp:ListItem>大专</asp:ListItem>
                                <asp:ListItem >本科</asp:ListItem>
                                <asp:ListItem>硕士</asp:ListItem>
                                <asp:ListItem>博士</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            工作经验：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                          <asp:DropDownList ID="ddlExperience" runat="server">
                                <asp:ListItem Selected="True">不限</asp:ListItem>
                                <asp:ListItem>在读学生</asp:ListItem>
                                <asp:ListItem>应届毕业生</asp:ListItem>
                                <asp:ListItem>一年以上</asp:ListItem>
                                <asp:ListItem>二年以上</asp:ListItem>
                                <asp:ListItem>三年以上</asp:ListItem>
                                <asp:ListItem>五年以上</asp:ListItem>
                                <asp:ListItem>八年以上</asp:ListItem>
                                <asp:ListItem>十年以上</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            薪资待遇：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                          <asp:DropDownList ID="ddlTreatment" runat="server">
                                 <asp:ListItem Selected="True">面议</asp:ListItem>
                                <asp:ListItem>1500以下</asp:ListItem>
                                <asp:ListItem>1500-1999</asp:ListItem>
                                <asp:ListItem>2000-2999</asp:ListItem>
                                <asp:ListItem>3000-4499</asp:ListItem>
                                <asp:ListItem >4500-5999</asp:ListItem>
                                <asp:ListItem>6000-7999</asp:ListItem>
                                <asp:ListItem>8000-9999</asp:ListItem>
                        <asp:ListItem>10000以上</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                  
                     <tr>
                        <th>
                            工作地点：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtAddress" runat="server" type="text" style="width:150px;" /><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            职位描述：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                       <textarea id="myEditor" name="myEditor" runat="server" style=" width:99%; height:300px;"></textarea>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            任职条件：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                       <textarea id="myEditor2" name="myEditor2" runat="server" style=" width:99%; height:300px;"></textarea>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            发布日期：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtReleaseTime" runat="server" type="text" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd'})"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            截止日期：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtCutTime" runat="server" type="text" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd'})"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:Button ID="btnAdd" runat="server" Text="发布" OnClientClick="return check()" 
                                onclick="btnAdd_Click"  />&nbsp;<input id="BtnBackProList" type="button" value="返回"  onclick='javascript:history.go(-1)'   />
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