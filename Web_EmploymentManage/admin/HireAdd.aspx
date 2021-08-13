<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HireAdd.aspx.cs" Inherits="admin_HireAdd" ValidateRequest="false" %>

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
    var editor1 = K.create('#myEditor1', {
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

<script>
    KindEditor.ready(function(K) {
        var editor1 = K.create('#myEditor2', {
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
            <th  style="width:15%">招聘企业：
                </th>
            <td  style="text-align:left; width:85%">
              <%=BLL.EnterpriseBLL.GetIdByEnterprise(model.EnterpriseId).EnterpriseName%>
                </td>
        </tr>
        <tr>
            <th>
                职位名称：</th>
            <td style="text-align:left;">
               <%=model.Job.Trim() %>
               </td>
       
        </tr>
        <tr>
            <th>工作类型：
                </th>
            <td  style="text-align:left;">
               <%=model.JobType.Trim()%>
                </td>
        </tr>
        <tr>
            <th>招聘人数：
                </th>
            <td  style="text-align:left;">
             <%= model.HireCount.Trim()%>
                </td>
        </tr>
        <tr>
            <th>年龄要求：
                </th>
            <td  style="text-align:left;">
               <%=model.Age.Trim()%>
                </td>
        </tr>
        <tr>
            <th>性别要求：
                </th>
            <td  style="text-align:left;">
               <%=model.Sex.Trim()%>
                </td>
        </tr>
        <tr>
            <th>学历要求：
                </th>
            <td  style="text-align:left;">
               <%=model.Education.Trim() %>
                </td>
        </tr>
        <tr>
            <th>工作经验：
                </th>
            <td  style="text-align:left;">
              <%= model.Experience.Trim()%>
                </td>
        </tr>
        <tr>
            <th>薪资待遇：
                </th>
            <td  style="text-align:left;">
                <%=model.Treatment.Trim()%>
                </td>
        </tr>
        <tr>
            <th>工作地点：
                </th>
            <td  style="text-align:left;">
                <%=model.Address.Trim()%>
                </td>
        </tr>
        <tr>
            <th>职位描述：
                </th>
            <td  style="text-align:left;">
                         <%= model.Note%>
                </td>
        </tr>
        
        
        <tr>
          <th>
                任职条件：</th>
            <td style="text-align:left;">
          <%=model.Conditions%>

                </td>
        </tr>
        <tr>
            <th>发布日期：
                </th>
            <td  style="text-align:left;">
              <%= model.ReleaseTime.ToString("yyyy-MM-dd")%>
                </td>
        </tr>
        <tr>
            <th>截止日期：
                </th>
            <td  style="text-align:left;">
                <%=model.CutTime.ToString("yyyy-MM-dd")%>
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