<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EnterpriseAdd.aspx.cs" Inherits="admin_EnterpriseAdd" ValidateRequest="false" %>

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
            <th  style="width:15%">
                账号：</th>
            <td style="text-align:left; width:85%">
               <%=model.UserName.Trim()%>
               </td>
        </tr>
        <tr>
            <th>密码：
                </th>
            <td  style="text-align:left;">
               <%=model.Pwd.Trim()%>
                </td>
        </tr>
        <tr>
            <th>企业编号：
                </th>
            <td  style="text-align:left;">
              <%=model.EnterpriseNo.Trim()%>
                </td>
        </tr>
        <tr>
            <th>企业名称：
                </th>
            <td  style="text-align:left;">
                <%=model.EnterpriseName.Trim()%>
                </td>
        </tr>
        <tr>
            <th>企业行业：
                </th>
            <td  style="text-align:left;">
              <%=model.Industry.Trim()%>
                </td>
        </tr>
        <tr>
            <th>企业性质：
                </th>
            <td  style="text-align:left;">
              <%=model.Nature.Trim()%>
                </td>
        </tr>
        <tr>
            <th>企业规模：
                </th>
            <td  style="text-align:left;">
                <%=model.Sizes.Trim() %>
                </td>
        </tr>
        <tr>
            <th>成立时间：
                </th>
            <td  style="text-align:left;">
               <%=model.SetUpTime.Trim()%>
                </td>
        </tr>
        <tr>
            <th>注册资金：
                </th>
            <td  style="text-align:left;">
               <%=model.Moneys.ToString().Trim() != "0" ? model.Moneys.ToString().Trim() : ""%>
                </td>
        </tr>
        <tr>
            <th>邮箱：
                </th>
            <td  style="text-align:left;">
               <%=model.Email.Trim() %>
                </td>
        </tr>
        <tr>
            <th>址址：
                </th>
            <td  style="text-align:left;">
              <%=model.Address.Trim()%>
                </td>
        </tr>
        
        <tr>
          <th>
                企业简介：</th>
            <td style="text-align:left;">
            <%=model.Note%>

                </td>
        </tr>
        <tr>
            <th>注册时间：
                </th>
            <td  style="text-align:left;">
             <%=model.RegisteredTime.ToString("yyyy-MM-dd HH:mm:ss").Trim()%>
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