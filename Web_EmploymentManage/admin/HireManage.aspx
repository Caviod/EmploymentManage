<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HireManage.aspx.cs" Inherits="admin_HireManage" %>

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
   <div class="Body_Title">查看招聘信息</div>
    <div>
    <div style="line-height:30px;   text-align:center;  height:30px;">
    关键词：<input id="txtKey" runat="server" type="text" title="职位名称" />&nbsp;<asp:Button ID="btnSearch" runat="server" 
            Text="查询" onclick="btnSearch_Click" />
    </div>
        <asp:Repeater ID="RpNews" runat="server">
        <HeaderTemplate>
            <table onmouseover="changeto()"  onmouseout="changeback()" class="Admin_Table" >
                <thead>
                    <tr class="Admin_Table_Title">
                        <th >选择</th>
                        <th >职位名称</th>
                        <th >工作类型</th>
                        <th >招聘人数</th>
                        <th >年龄要求</th>
                        <th >性别要求</th>
                        <th>学历要求</th>
                        <th >工作经验</th>
                        <th >薪资待遇</th>
                        <th >工作地点</th>
                       <th >发布日期</th>
                       <th >截止日期</th>
                       <th >详细操作</th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td align="center"><input type="checkbox" value='<%#Eval("HireId") %>' name="CheckMes" /></td>
                <td align="center"><%#Eval("Job")%></td>
                <td align="center"><%#Eval("JobType")%></td>
                  <td align="center"><%#Eval("HireCount")%></td>
                   <td align="center"><%#Eval("Age")%></td>
                    <td align="center"><%#Eval("Sex")%></td>
                     <td align="center"><%#Eval("Education")%></td>
                      <td align="center"><%#Eval("Experience")%></td>
                       <td align="center"><%#Eval("Treatment")%></td>
                       <td align="center"><%#Eval("Address")%></td>
                       <td align="center"><%#Convert.ToDateTime(Eval("ReleaseTime")).ToString("yyyy-MM-dd")%></td>
                <td align="center"><%#Convert.ToDateTime(Eval("CutTime")).ToString("yyyy-MM-dd")%></td>
                <td align="center">
                    <a href="HireAdd.aspx?id=<%#Eval("HireId") %>"><img src="image/MillMes_ICO.gif" style="vertical-align:top;" alt="详细" /></a>
                    <asp:ImageButton ID="ibDel" runat="server" ToolTip="删除" ImageUrl="image/Delete.gif" OnClick="ibDel_ItemDeleting"
                                    CommandArgument='<%# Eval("HireId") %>' OnClientClick="return confirm('确定删除当前项?')" />
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

