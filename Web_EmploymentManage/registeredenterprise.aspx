<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registeredenterprise.aspx.cs" Inherits="registeredenterprise" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />

    


 <script language="javascript" type="text/javascript">

     function check() {
         var txtUserName = document.getElementById("txtUserName");
         
        
         var txtNewPwd = document.getElementById("txtNewPwd");
         var txtSureNewPwd = document.getElementById("txtSureNewPwd");

         var txtEnterpriseNo = document.getElementById("txtEnterpriseNo");
         var txtEnterpriseName = document.getElementById("txtEnterpriseName");
         if (txtUserName.value == "") {

             alert("带红色 * 号项不能为空！");
             txtUserName.focus();
             return false;
         }
         if (txtNewPwd.value == "") {

             alert("带红色 * 号项不能为空！");
             txtNewPwd.focus();
             return false;
         }
         if (txtNewPwd.value != "") {
             if (txtNewPwd.value.length < 6) {
                 alert("密码必须6位或6位以上！");
                 txtNewPwd.focus();
                 return false;
             }
         }
         if (txtSureNewPwd.value == "") {

             alert("带红色 * 号项不能为空！");
             txtSureNewPwd.focus();
             return false;
         }
         if (txtSureNewPwd.value != "") {
             if (txtSureNewPwd.value.length < 6) {
                 alert("密码必须6位或6位以上！");
                 txtSureNewPwd.focus();
                 return false;
             }
         }
         if (txtNewPwd.value != txtSureNewPwd.value) {

             alert("两次密码不一致！");
             txtSureNewPwd.focus();
             return false;
         }
         if (txtEnterpriseNo.value == "") {

             alert("带红色 * 号项不能为空！");
             txtEnterpriseNo.focus();
             return false;
         }
         if (txtEnterpriseName.value == "") {

             alert("带红色 * 号项不能为空！");
             txtEnterpriseName.focus();
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
          <%--  <div class="menu-blank" id="menu7" onmousemove="chnage('menu7')" onmouseout="chnage2('menu7')">
                <a href="messagelist.aspx">交流区</a></div>--%>
        </div>
        <div class="blank02">
        </div>
        <div class="newsdetail2">
            <div class="newsdetail2-1">
                企业注册</div>
               <div class="blank02"></div>
            <div class="enterprisedetail2-2-about">
                <table style="width: 100%; padding-left: 20px; padding-right: 20px;">
                    <tr>
                        <th style="width:30%">
                            账号：
                        </th>
                        <td style="  text-align:left; padding-left:20px; width:70%;">
                            <input id="txtUserName" runat="server" type="text" style="width:200px;" /><span  style="color:Red;">* 账号注册后不可更改</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            密码：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtNewPwd" runat="server" type="password" style="width:200px;"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            确认密码：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtSureNewPwd" runat="server" type="password" style="width:200px;"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            企业编号：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtEnterpriseNo" runat="server" type="text" style="width:200px;"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            企业名称：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <input id="txtEnterpriseName" runat="server" type="text" style="width:200px;"/><span  style="color:Red;">*</span>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            企业行业：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:DropDownList ID="ddlIndustry" runat="server" >
                                <asp:ListItem Selected="True">计算机/互联网/通信/电子</asp:ListItem>
                                <asp:ListItem>会计/金融/银行/保险</asp:ListItem>
                                <asp:ListItem>贸易/消费/制造/营运</asp:ListItem>
                                <asp:ListItem>制药/医疗</asp:ListItem>
                                <asp:ListItem>计算机/互联网/通信/电子</asp:ListItem>
                                <asp:ListItem>广告/媒体</asp:ListItem>
                                <asp:ListItem>房地产/建筑</asp:ListItem>
                                <asp:ListItem>专业服务/教育/培训</asp:ListItem>
                                <asp:ListItem>服务业</asp:ListItem>
                                <asp:ListItem>物流/运输</asp:ListItem>
                                <asp:ListItem>能源/原材料</asp:ListItem>
                                <asp:ListItem>政府/非赢利机构/其它</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            企业性质：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:DropDownList ID="ddlNature" runat="server">
                            
                            <asp:ListItem>外资(欧美)</asp:ListItem>
                                <asp:ListItem>外资(非欧美)</asp:ListItem>
                                <asp:ListItem>合资(欧美)</asp:ListItem>
                                <asp:ListItem>合资(非欧美)</asp:ListItem>
                                <asp:ListItem>国企</asp:ListItem>
                                <asp:ListItem Selected="True">民营公司</asp:ListItem>
                                <asp:ListItem>外企代表处</asp:ListItem>
                                <asp:ListItem>政府机关</asp:ListItem>
                                <asp:ListItem>事业单位</asp:ListItem>
                                <asp:ListItem>非盈利机构</asp:ListItem>
                                <asp:ListItem>其它性质</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                     <tr>
                        <th>
                            企业规模：
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                             <asp:DropDownList ID="ddlSizes" runat="server">
                             <asp:ListItem>50人以下</asp:ListItem>
                            <asp:ListItem Selected="True">50-150人</asp:ListItem>
                                <asp:ListItem>150-500人</asp:ListItem>
                                <asp:ListItem>500-1000人</asp:ListItem>
                                <asp:ListItem>10000人以上</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            
                        </th>
                        <td style=" text-align:left; padding-left:20px;">
                            <asp:Button ID="btnAdd" runat="server" Text="注册" OnClientClick="return check()" onclick="btnAdd_Click" />&nbsp;<input id="Reset1" type="reset"
                                value="重置" />
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
