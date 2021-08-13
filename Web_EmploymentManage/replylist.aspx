<%@ Page Language="C#" AutoEventWireup="true" CodeFile="replylist.aspx.cs" Inherits="replylist" %>
<%@ Register Assembly="UcfarPager" Namespace="UcfarPager" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />

   <script language="javascript" type="text/javascript">

       function check() {


          
           var txtMessageContent = document.getElementById("txtMessageContent");

           
           if (txtMessageContent.value == "") {
               alert("内容不能为空！");
               txtMessageContent.focus();
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
           <%-- <div class="menu-blank" id="menu7" onmousemove="chnage('menu7')" onmouseout="chnage2('menu7')">
                <a href="messagelist.aspx">交流区</a></div>--%>
        </div>
        <div class="blank02">
        </div>
        <div class="newsdetail2">
            <div class="newsdetail2-1">
                回复详细</div>
                <div class="blank02"></div>
            <div class="enterprisedetail2-2-about">
                 <table  style="width: 100%; padding-left: 20px; padding-right: 20px;">
 <tr>
 <th style=" width:100px;"><%=msg.MsgId != 0 ? BLL.UsersBLL.GetIdByUsers(msg.UserId).UserName : "匿名网友"%></th><td style="width:696px; text-align:left; padding-left:20px; padding-right:20px;"><span style=" float:left;"><%=msg.MsgId != 0 ? msg.MsgTitle : ""%></span><span style=" float:right;"><%=msg.MsgId!=0?msg.MsgTime.ToString("yyyy-MM-dd HH:mm:ss"):"" %></span></td>
 </tr>
 <tr>
 <th style=" width:100px;"><img alt="" src="<%=msg.MsgId != 0 ? BLL.UsersBLL.GetIdByUsers(msg.UserId).HeadImg : ""%>" style="width:65px; height:80px;" /></th>
    <td style=" height:100px;width:696px;  text-align:left; padding-left:20px; padding-right:20px; line-height:20px; vertical-align:text-top;"><%=msg.MsgId != 0 ? msg.MsgContent : ""%></td>
 </tr>
 </table>
 <div class="blank02"></div>
 <div class="blank02"></div>
    <asp:Repeater ID="rpView" runat="server">
       
        <ItemTemplate>  
 <table  style="width: 100%; padding-left: 20px; padding-right: 20px;">
 
 <tr>
 <th style=" width:80px;"><img alt="" src="<%#Convert.ToInt32(Eval("UserId")) != 0 ? BLL.UsersBLL.GetIdByUsers(Convert.ToInt32(Eval("UserId"))).HeadImg : ""%>" style="width:40px; height:50px;" /></th>
     <td style=" height:80px; width:696px; text-align:left; padding-left:20px; padding-right:20px; line-height:20px; vertical-align:text-top;"><%#Eval("ReplyContent")%></td>
 </tr>
 <tr>
 <th style=" width:80px;"><%#Convert.ToInt32(Eval("UserId")) != 0 ? BLL.UsersBLL.GetIdByUsers(Convert.ToInt32(Eval("UserId"))).UserName : "匿名网友"%></th><td style="width:696px; text-align:left; padding-left:20px; padding-right:20px;"><span style=" float:left;"></span><span style=" float:right;"><%#Eval("ReplyTime")%></span></td>
 </tr>
 
 </table>
 <div class="blank02"></div>
 </ItemTemplate>
 </asp:Repeater>
                
            </div>
            <div style=" height:30px; line-height:30px">
            <cc1:UcfarPager ID="UcfarPager1" runat="Server" 
            PageSize="5" NavigatePreviousText="上一页" NavigateNextText="下一页" MainTableStyle="text-align:center;"
            LeftPageNumberBoxPadding="2px 5px 2px 5px" DisplayPagerNum="5" PageLinkForeColor="#0099FF"
            PageLinkHoverBackColor="#0099FF" PageLinkSelectedBackColor="#0099FF" PageLinkSelectedBorderColor="#0099FF"
            PageNumberBoxBorderColor="#0099FF" PageNumberHoverBorderColor="#0099FF"   onpagechanged="UcfarPager1_PageChanged">
        </cc1:UcfarPager>
        </div>
        <div class="blank02"></div>
         <div class="enterprisedetail2-2-about">
        <table style="width: 100%; padding-left: 20px; padding-right: 20px;">
 <tr>
 <th style=" width:200px;">回复人：</th><td style="width:696px; text-align:left; padding-left:20px; padding-right:20px;"><asp:Label ID="lblUserName" runat="server" ></asp:Label></td>
 </tr>
 <tr>
 <th style=" width:200px;">内容：</th><td style="width:696px; text-align:left; padding-left:20px; padding-right:20px; line-height:20px;">
     <textarea id="txtMessageContent" runat="server" style="width:100%; height:100px;" cols="20" name="S1" rows="2"></textarea></td>
 </tr>
 <tr>
 <th style=" width:200px;"></th><td style="width:696px; text-align:left; padding-left:20px; padding-right:20px;">
     <asp:Button ID="btnAdd" runat="server" Text="回复" 
         OnClientClick="return check();" onclick="btnAdd_Click"/><input id="btnReset" type="reset"
         value="重置" /></td>
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