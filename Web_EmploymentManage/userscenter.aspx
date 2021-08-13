<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userscenter.aspx.cs" Inherits="userscenter"
    ValidateRequest="false" %>

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

    <script language="javascript" type="text/javascript">

         function check() {

             var txtRealName = document.getElementById("txtRealName");
             var txtIdCard = document.getElementById("txtIdCard");

             var txtPenetration = document.getElementById("txtPenetration");
             var txtBirth = document.getElementById("txtBirth");
             var txtGraduationTime = document.getElementById("txtGraduationTime");
             var txtAddress = document.getElementById("txtAddress");

             var txtColleges = document.getElementById("txtColleges");
             var txtMajor = document.getElementById("txtMajor");
             
             var txtAge = document.getElementById("txtAge");
             
             var txtPhone = document.getElementById("txtPhone");
             var txtEmail = document.getElementById("txtEmail");
             

             if (txtRealName.value == "") {
                 alert("带红色 * 号项不能为空！");
                 txtRealName.focus();
                 return false;
             }
             if (txtIdCard.value == "") {
                 alert("带红色 * 号项不能为空！");
                 txtIdCard.focus();
                 return false;
             }
             if (!(/(^\d{15}$)|(^\d{17}([0-9]|X)$)/.test(txtIdCard.value))) {
                 alert('输入的身份证号长度不对，或者号码不符合规定！\n15位号码应全为数字，18位号码末位可以为数字或X。');
                 txtIdCard.focus();
                 return false;
             }

             if (txtPenetration.value == "") {
                 alert("带红色 * 号项不能为空！");
                 txtPenetration.focus();
                 return false;
             }

             if (txtBirth.value == "") {
                 alert("带红色 * 号项不能为空！");
                 txtBirth.focus();
                 return false;
             }
           
            
             
             
             if (txtAge.value == "") {
                 alert("带红色 * 号项不能为空！");
                 txtAge.focus();
                 return false;
             }
             if (txtMajor.value == "") {
                 alert("带红色 * 号项不能为空！");
                 txtMajor.focus();
                 return false;
             }
             if (txtColleges.value == "") {
                 alert("带红色 * 号项不能为空！");
                 txtColleges.focus();
                 return false;
             }
             if (txtGraduationTime.value == "") {
                 alert("带红色 * 号项不能为空！");
                 txtGraduationTime.focus();
                 return false;
             }
          
    if (txtPhone.value != "") {
             if (txtPhone.value.length == 11) {
                 var regPartton = /1[3-8]+\d{9}/;
                 if (!regPartton.test(txtPhone.value)) {
                     alert("请输入正确的手机号码！");
                     txtPhone.focus();
                     return false;
                 }
             }
             else {
                 alert("手机号码必须是11位！");
                 txtPhone.focus();
                 return false;
             }
         }
         else {
             alert("带红色 * 号项不能为空！");
             txtPhone.focus();
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
          <%--  <div class="menu-blank" id="menu7" onmousemove="chnage('menu7')" onmouseout="chnage2('menu7')">
                <a href="messagelist.aspx">交流区</a></div>--%>
        </div>
        <div class="blank02">
        </div>
        <div class="leftbody">
            <div class="leftcenter2">
                <div class="leftcenter2-1" >
                    个人中心</div>
                <ul >
                    <li><a href="userscenter.aspx"><span style="padding-left:60px;">修改个人信息</span></a></li>
                    <li><a href="myapply.aspx"><span style="padding-left:60px;">查看已申请过的职位</span></a></li>
                    <%--<li><a href="myusersinfo.aspx"><span style="padding-left:60px;">查看企业来信</span></a></li>
                    <li><a href="myuserssendinfo.aspx"><span style="padding-left:60px;">查看发出私信</span></a></li>--%>
                    <li><a href="updatepwd.aspx"><span style="padding-left:60px;">修改密码</span></a></li>
                    <li><asp:LinkButton ID="lnkbOut" runat="server" OnClientClick="return confirm('确定要退出吗？')" onclick="lnkbOut_Click"><span style="padding-left:60px;">退出中心</span></asp:LinkButton></li>
                </ul>
            </div>
        </div>
        <div class="rightbody">
            <div class="rightarea2">
                <div class="rightarea2-1">
                    录入/修改个人信息</div>
                <table style="width: 100%;">
                    <tr>
                        <th style="width: 20%;">
                            学号：
                        </th>
                        <td style="text-align: left; padding-left: 20px; width: 80%;">
                            <asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            姓名：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtRealName" runat="server" type="text" /><span style="color: Red;">*</span>
                        </td>
                    </tr>
                    <%--<tr>
                        <th>
                            头像：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <asp:FileUpload ID="fupPhoto" runat="server" onchange="CheckImgCss(this, 'imgPicture');" /><br />
                            <img id="imgPicture" runat="server" style="width: 100px; height: 120px;" />
                        </td>
                    </tr>
                    <tr>--%>
                        <th>
                            性别：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <asp:DropDownList ID="ddlSex" runat="server">
                                <asp:ListItem>男</asp:ListItem>
                                <asp:ListItem>女</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <%--<tr>
                        <th>
                            身份证：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtIdCard" runat="server" type="text" onkeyup="this.value=this.value.replace(/\D/g,'')"
                                onafterpaste="this.value=this.value.replace(/\D/g,'')" /><span style="color: Red;">*</span>
                        </td>
                    </tr>--%>
                   <%-- <tr>
                        <th>
                            贯籍：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtPenetration" runat="server" type="text"  style="width:200px;" /><span style="color: Red;">*</span>
                        </td>
                    </tr>--%>
                     <tr>
                        <th>
                            出生日期：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtBirth" runat="server" type="text" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd'})"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            年龄：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtAge" runat="server" type="text" onkeyup="this.value=this.value.replace(/\D/g,'')"
                                onafterpaste="this.value=this.value.replace(/\D/g,'')" /><span style="color: Red;">*
                                    </span>&nbsp;</td>
                    </tr>
                    <tr>
                        <th>
                            政治背景：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <asp:DropDownList ID="ddlPolitical" runat="server">
                                <asp:ListItem>群众</asp:ListItem>
                                <asp:ListItem>共青团员</asp:ListItem>
                                <asp:ListItem>中共预备党员</asp:ListItem>
                                <asp:ListItem>中共党员</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                   <%-- </tr>
                      <tr>
                        <th>
                            工作经验：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                          <asp:DropDownList ID="ddlExperience" runat="server">
                               
                                <asp:ListItem>在读学生</asp:ListItem>
                                <asp:ListItem Selected="True">应届毕业生</asp:ListItem>
                                <asp:ListItem>一年以上</asp:ListItem>
                                <asp:ListItem>二年以上</asp:ListItem>
                                <asp:ListItem>三年以上</asp:ListItem>
                                <asp:ListItem>五年以上</asp:ListItem>
                                <asp:ListItem>八年以上</asp:ListItem>
                                <asp:ListItem>十年以上</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>--%>
                    <tr>
                        <th>
                            学历：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <asp:DropDownList ID="ddlEducation" runat="server">
<%--                                <asp:ListItem>高中</asp:ListItem>
                                <asp:ListItem>中技</asp:ListItem>
                                <asp:ListItem>中专</asp:ListItem>
                                <asp:ListItem>大专</asp:ListItem>--%>
                                <asp:ListItem>本科</asp:ListItem>
                                <asp:ListItem>硕士</asp:ListItem>
                                <asp:ListItem>博士</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            专业：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtMajor" runat="server" type="text" style="width: 200px;" /><span style="color: Red;">*</span>
                        </td>
                    </tr>
<%--                    <tr>
                        <th>
                            毕业院校：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtColleges" runat="server" type="text" style="width: 200px;" /><span
                                style="color: Red;">*</span>
                        </td>
                    </tr>--%>
                    <tr>
                        <th>
                            毕业时间：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtGraduationTime" runat="server" type="text" onfocus="WdatePicker({dateFmt:'yyyy-MM'})" /><span
                                style="color: Red;">*</span>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            是否就业：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <asp:DropDownList ID="ddlIsEmployment" runat="server">
                                <asp:ListItem>是</asp:ListItem>
                                <asp:ListItem>否</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>

                    <tr>
                        <th>
                            联系手机：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtPhone" runat="server" type="text" onkeyup="this.value=this.value.replace(/\D/g,'')"
                                onafterpaste="this.value=this.value.replace(/\D/g,'')" />
                                    </span>
                        </td>
                    </tr>
                   <tr>
                        <th>
                            就业公司全称：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtEmail" runat="server" type="text" />
                        </td>
                    </tr>
                    <%--<tr>
                        <th>
                            日前所在地：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <input id="txtAddress" runat="server" type="text" style="width: 200px;" /><span
                                style="color: Red;">*</span>
                        </td>
                    </tr>--%>
              <%--     <tr>
                        <th>
                            技能介绍：
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <textarea id="myEditor" name="myEditor" runat="server" style="width: 99%; height: 300px;"></textarea>
                        </td>
                    </tr>--%>
                    <tr>
                        <th>
                        </th>
                        <td style="text-align: left; padding-left: 20px;">
                            <asp:Button ID="btnUpdate" runat="server" Text="修改" OnClientClick="return check()"
                                OnClick="btnUpdate_Click" />
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