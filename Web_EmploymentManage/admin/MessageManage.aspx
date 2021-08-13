<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessageManage.aspx.cs" Inherits="admin_MessageManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
     <link href="css/Manage.css" rel="stylesheet" type="text/css" />

    <script src="JavaScript/Jquery.js" type="text/javascript"></script>
    <script src="JavaScript/Add.js" type="text/javascript"></script>
    <script src="JavaScript/ChangeColor.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
   <div class="Body_Title">查看留言</div>
    <div>
    
        <asp:Repeater ID="RpNews" runat="server">
        <HeaderTemplate>
            <table onmouseover="changeto()"  onmouseout="changeback()" class="Admin_Table" >
                <thead>
                    <tr class="Admin_Table_Title">
                        <th >选择</th>
                        <th >留言人</th>
                        <th >标题</th>
                         <th >内容</th>
                       
                        <th >留言时间</th>
                       
                        <th >详细操作</th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td align="center"><input type="checkbox" value='<%#Eval("MsgId") %>' name="CheckMes" /></td>
                <td align="center"><%#BLL.UsersBLL.GetIdByUsers(Convert.ToInt32(Eval("UserId"))).UserName%></td>
                <td align="center" title='<%#Eval("MsgTitle")%>'><%#Eval("MsgTitle").ToString().Length > 15 ? Eval("MsgTitle").ToString().Substring(0,15) + "..." : Eval("MsgTitle").ToString()%></td>
                <td align="center" title='<%#Eval("MsgContent")%>'><%#Eval("MsgContent").ToString().Length > 30 ? Eval("MsgContent").ToString().Substring(0, 30) + "..." : Eval("MsgContent").ToString()%></td>
                   <td align="center"><%#Eval("MsgTime")%></td>
                <td align="center"> <a href="ReplyManage.aspx?id=<%#Eval("MsgId") %>"><img src="image/MillMes_ICO.gif" style="vertical-align:top;" alt="查看回复" /></a>
                    <asp:ImageButton ID="ibDel" runat="server" ToolTip="删除" ImageUrl="image/Delete.gif" OnClick="ibDel_ItemDeleting"
                                    CommandArgument='<%# Eval("MsgId") %>' OnClientClick="return confirm('确定删除当前项?')" />
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate></table></FooterTemplate>
    </asp:Repeater>
    <div class="Body_Search">
        <div class="page_Left">
            <input id="BtnAllSelect" type="button" value="全选" />&nbsp;<asp:Button ID="BtnAllDel" runat="server" Text="删除选中" onclick="BtnAllDel_Click" 
                ForeColor="Red" />
        </div>
        <div class="page_Right">
            <asp:Label runat="server" ID="PageMes"></asp:Label>
            <asp:LinkButton ID="LBHome" runat="server" CssClass="pageBtn" 
                onclick="LBHome_Click">[首页]</asp:LinkButton>
            <asp:LinkButton ID="LBUp" runat="server" CssClass="pageBtn" 
                onclick="LBUp_Click">[上一页]</asp:LinkButton>
            <asp:LinkButton ID="LBNext" runat="server" CssClass="pageBtn" 
                onclick="LBNext_Click">[下一页]</asp:LinkButton>
            <asp:LinkButton ID="LBEnd" runat="server" CssClass="pageBtn" 
                onclick="LBEnd_Click">[尾页]</asp:LinkButton>
        </div>
    </div>
    </div>
    <asp:HiddenField ID="HSelectID" runat="server" Value=""/>
    <asp:HiddenField ID="HNowPage" runat="server" Value="1"/><!--当前页-->
    <asp:HiddenField ID="HPageSize" runat="server" Value=""/><!--共多少条-->
    <asp:HiddenField ID="HAllPage" runat="server" Value="0"/><!--总共多少页-->
    <asp:HiddenField ID="HCount" runat="server" Value="15"/><!--每页多少条-->
    </form>
</body>
</html>
