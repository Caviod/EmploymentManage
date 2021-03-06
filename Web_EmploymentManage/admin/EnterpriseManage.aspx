<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EnterpriseManage.aspx.cs" Inherits="admin_EnterpriseManage" %>

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
   <div class="Body_Title">查看企业信息</div>
    <div>
    <div style="line-height:30px;   text-align:center;  height:30px;">
    关键词：<input id="txtKey" runat="server" type="text" title="账号，企业编号，企业名称" />&nbsp;<asp:Button ID="btnSearch" runat="server" 
            Text="查询" onclick="btnSearch_Click" />
    </div>
        <asp:Repeater ID="RpNews" runat="server">
        <HeaderTemplate>
            <table onmouseover="changeto()"  onmouseout="changeback()" class="Admin_Table" >
                <thead>
                    <tr class="Admin_Table_Title">
                        <th >选择</th>
                        <th >账号</th>
                        <th >企业编号</th>
                        <th >企业名称</th>
                        <th >企业行业</th>
                        <th >企业性质</th>
                         <th >企业规模</th>
                        <th >成立时间</th>
                        <th >注册资金</th>
                        <th >注册时间</th>
                       
                        <th >详细操作</th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td align="center"><input type="checkbox" value='<%#Eval("EnterpriseId") %>' name="CheckMes" /></td>
                <td align="center"><%#Eval("UserName")%></td>
                <td align="center"><%#Eval("EnterpriseNo")%></td>
                  <td align="center"><%#Eval("EnterpriseName")%></td>
                   <td align="center"><%#Eval("Industry")%></td>
                    <td align="center"><%#Eval("Nature")%></td>
                     <td align="center"><%#Eval("Sizes")%></td>
                      <td align="center"><%#Eval("SetUpTime")%></td>
                       <td align="center"><%#Eval("Moneys").ToString().Trim()!="0"?Eval("Moneys").ToString().Trim():""%></td>
                <td align="center"><%#Eval("RegisteredTime")%></td>
                <td align="center">
                    <a href="EnterpriseAdd.aspx?id=<%#Eval("EnterpriseId") %>"><img src="image/MillMes_ICO.gif" style="vertical-align:top;" alt="详细" /></a>
                    <asp:ImageButton ID="ibDel" runat="server" ToolTip="删除" ImageUrl="image/Delete.gif" OnClick="ibDel_ItemDeleting"
                                    CommandArgument='<%# Eval("EnterpriseId") %>' OnClientClick="return confirm('确定删除当前项?')" />
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

