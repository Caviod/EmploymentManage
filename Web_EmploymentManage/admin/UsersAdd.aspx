<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersAdd.aspx.cs" Inherits="admin_UsersAdd" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
    <link href="css/Manage.css" rel="stylesheet" type="text/css" />

    

 <link href="kindeditor/themes/default/default.css" rel="stylesheet" type="text/css" />

    <link href="kindeditor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />

    <script src="kindeditor/kindeditor.js" type="text/javascript"></script>


    <script src="kindeditor/lang/zh_CN.js" type="text/javascript"></script>

    <script src="kindeditor/plugins/code/prettify.js" type="text/javascript"></script>
<script>
    KindEditor.ready(function(K) {
    var editor1 = K.create('#myEditor', {
            cssPath: 'kindeditor/plugins/code/prettify.css',
            uploadJson: 'kindeditor/upload_json.ashx',
            fileManagerJson: 'kindeditor/file_manager_json.ashx',
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


         
</head>
<body>
    <form id="form1" runat="server">
    <div class="div_All">
    <div class="Body_Title"><%=strNav%></div>
      
    </div>
    <table style="width:100%; line-height:30px;" >
        
        <tr>
            <th  style="width:15%">学号：</th>
            <td style="text-align:left; width:85%">
              <%= model.UserName.Trim() %>
              </td>
        </tr>
        <tr>
            <th>密码：
                </th>
            <td  style="text-align:left;">
                <%=model.Pwd.Trim()%>
                </td>
        </tr>
       <%-- <tr>
            <th>头像：
                </th>
            <td  style="text-align:left;">
               
                <img  src='<%=model.HeadImg!=""?model.HeadImg.Substring(6):""%>'  style=" width:120px; height:150px;" />
                </td>
        </tr>--%>
        <tr>
            <th>姓名：
                </th>
            <td  style="text-align:left;">
                <%= model.RealName.Trim()%>
                </td>
        </tr>
        <tr>
            <th>性别：
                </th>
            <td  style="text-align:left;">
              <%=model.Sex.Trim() %>
                </td>
        </tr>
        <%--<tr>
            <th>身份证：
                </th>
            <td  style="text-align:left;">
                <%= model.IdCard.Trim() %>
                </td>
        </tr>--%>
        
       <%-- <tr>
            <th>贯籍：
                </th>
            <td  style="text-align:left;">
              <%=model.Penetration.Trim()%>
                </td>
        </tr>--%>
        
        <tr>
            <th>出生日期：
                </th>
            <td  style="text-align:left;">
               <%=model.Birth.ToString("yyyy-MM-dd") != "1900-01-01" ? model.Birth.ToString("yyyy-MM-dd") : ""%>
                </td>
        </tr>
        
      
        
        <tr>
            <th>年龄：
                </th>
            <td  style="text-align:left;">
             <%=model.Age.ToString().Trim() != "0" ? model.Age.ToString().Trim() : ""%>
                </td>
        </tr>
        <tr>
            <th>政治背景：
                </th>
            <td  style="text-align:left;">
               <%=model.Political.Trim() %>
                </td>
        </tr>
        <%--<tr>
            <th>工作经验：
                </th>
            <td  style="text-align:left;">
                <%=model.Experience.Trim()%>
                </td>
        </tr>--%>
        <tr>
            <th>学历：
                </th>
            <td  style="text-align:left;">
               <%=model.Education.Trim()%>
                </td>
        </tr>
        <tr>
            <th>专业：
                </th>
            <td  style="text-align:left;">
               <%=model.Major.Trim()%>
                </td>
        </tr>
       <%-- <tr>
            <th>毕业院校：
                </th>
            <td  style="text-align:left;">
               <%=model.Colleges.Trim()%>
                </td>
        </tr>--%>
          <tr>
            <th>毕业时间：
                </th>
            <td  style="text-align:left;">
               <%=model.GraduationTime.Trim()%>
                </td>
        </tr>
        
        
        <tr>
            <th>是否就业：
                </th>
            <td  style="text-align:left;">
               <%= model.IsEmployment.Trim() %>
                </td>
        </tr>
        <tr>
            <th>联系方式：
                </th>
            <td  style="text-align:left;">
               <%= model.Phone.Trim()%>
                </td>
        </tr>
       <%-- <tr>
            <th>邮箱：
                </th>
            <td  style="text-align:left;">
               <%=model.Email.Trim()%>
                </td>
        </tr>--%>
        <%--<tr>
            <th>日前所在地：
                </th>
            <td  style="text-align:left;">
                <%= model.Address.Trim()%>
                </td>
        </tr>--%>
        <%--<tr>
          <th>
                技能介绍：</th>
            <td style="text-align:left;">
             <%=model.Introduce%>

                </td>
        </tr>--%>
        <tr>
            <th>注册时间：
                </th>
            <td  style="text-align:left;">
               <%=model.RegisteredTime.ToString("yyyy-MM-dd HH:mm:ss").Trim() %>
                </td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
 <input id="BtnBackProList" type="button" value="返回"  onclick='javascript:history.go(-1)'   /></td>
           
        </tr>
    </table>
    </form>
</body>
</html>