<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewsAdd.aspx.cs" Inherits="admin_NewsAdd" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
    <link href="css/Manage.css" rel="stylesheet" type="text/css" />

    <script src="JavaScript/My97DatePicker/WdatePicker.js" type="text/javascript"></script>


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


         <script language="javascript" type="text/javascript">


       function check() {

           var txtNewsTitle = document.getElementById("txtNewsTitle");
           var txtNewsTime = document.getElementById("txtNewsTime");
           if (txtNewsTitle.value == "") {
               alert("带红色 * 号项不能为空！");
               txtNewsTitle.focus();
               return false;
           }

           if (txtNewsTime.value == "") {
               alert("带红色 * 号项不能为空！");
               txtNewsTime.focus();
               return false;
           }




       }


      


   </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="div_All">
    <div class="Body_Title"><%=strNav%></div>
      
    </div>
    <table style="width:100%" >
        
        <tr>
            <th style="width:15%">标题：</th>
            <td style="text-align:left;width:85%">
                <input id="txtNewsTitle" type="text" style="width:300px;"  runat="server"/><span style="color:Red;">*</span></td>
         <%--<td rowspan="3"><img id="imgid" src="image/noImage.gif" runat="server" alt="图片信息" class="ProImg"/></td>--%>
        </tr>
        <tr>
            <th>作者：</th>
            <td  style="text-align:left;">
                <input id="txtNewsAuthor" type="text"  runat="server"/>
                </td>
        </tr>
        <tr>
            <th>来源：</th>
            <td  style="text-align:left;">
  <input id="txtSource" runat="server" type="text" />
                </td>
        </tr>
        <tr>
          <th>内容：</th>
            <td style="text-align:left;">
             <textarea id="myEditor" name="myEditor" runat="server" style=" width:90%; height:400px;"></textarea>

                </td>
        </tr>
        <tr>
            <th>发布时间：</th>
            <td  style="text-align:left;">
                <input id="txtNewsTime" type="text"  runat="server" onfocus="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'})"/><span style="color:Red;">*</span>
                </td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="添加"  OnClientClick="return check()" onclick="btnUpdate_Click" 
                    />&nbsp;<input id="BtnBackProList" type="button" value="返回"  onclick='javascript:history.go(-1)'   /></td>
           
        </tr>
    </table>
    </form>
</body>
</html>