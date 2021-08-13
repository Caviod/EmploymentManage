<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hiredetail.aspx.cs" Inherits="hiredetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>大学生就业信息管理系统</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />
<script language="javascript" type="text/javascript">

    function check() {

        var txtContent = document.getElementById("txtContent");



        if (txtContent.value == "") {
            alert("私信内容不能为空！");
            txtContent.focus();
            return false;
        }




    }
</script>
   
<style>
.mybutton{ vertical-align:bottom;}
</style>
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
<%--            <div class="menu-blank" id="menu2" onmousemove="chnage('menu2')" onmouseout="chnage2('menu2')">
                <a href="newslist.aspx">新闻资讯</a></div>--%>
            <div class="menu-blank" id="menu3" onmousemove="chnage('menu3')" onmouseout="chnage2('menu3')">
                <a href="enterpriselist.aspx">企业信息</a></div>
            <div class="menu-blank" id="menu4" onmousemove="chnage('menu4')" onmouseout="chnage2('menu4')">
                <a href="hirelist.aspx">招聘信息</a></div>
            <div class="menu-blank" id="menu5" onmousemove="chnage('menu5')" onmouseout="chnage2('menu5')">
                <a href="registeredenterprise.aspx">企业注册</a></div>
            <div class="menu-blank" id="menu6" onmousemove="chnage('menu6')" onmouseout="chnage2('menu6')">
                学生<a href="registeredusers.aspx">注册</a></div>
<%--            <div class="menu-blank" id="menu7" onmousemove="chnage('menu7')" onmouseout="chnage2('menu7')">
                <a href="messagelist.aspx">交流区</a></div>--%>
        </div>
        <div class="blank02">
        </div>
        <div class="newsdetail2">
        <div class="newsdetail2-1">职位详细</div>
        <div class="newsdetail2-2-title"><span style=" float:left; padding-left:40px; text-align:left;"><%=hire.HireId!=0?hire.Job:""%></span></div>
       <div class="enterprisedetail2-2-about">
        
        <table style="width:100%; padding-left:20px; padding-right:20px;">
        <tr><th  style=" text-align:left; padding-left:20px;">职位信息</th></tr>
             
        </table>
        <div class="blank03"></div>
        <table style="width:100%; padding-left:20px; padding-right:20px;">
          <tr>
                        <th>
                            企业名称：
                        </th>
                        <td colspan="7" style="text-align:left; padding-left:10px; color:#1f9de9; font-weight:bold; font-size:14px;">
                            <%=hire.HireId!=0?BLL.EnterpriseBLL.GetIdByEnterprise(hire.EnterpriseId).EnterpriseName:""%>
                        </td>
                        
                    </tr>
        <tr><th>工作类型：</th><td><%=hire.HireId!=0?hire.JobType:""%></td><th>学历要求：</th><td><%=hire.HireId!=0?hire.Education:""%></td><th>工作经验：</th><td><%=hire.HireId!=0?hire.Experience:""%></td><th>薪资待遇：</th><td><%=hire.HireId!=0?hire.Treatment:""%></td></tr>
              <tr><th>性别要求：</th><td><%=hire.HireId!=0?hire.Sex:""%></td><th>年龄要求：</th><td><%=hire.HireId!=0?hire.Age:""%></td><th>工作地点：</th><td><%=hire.HireId!=0?hire.Address:""%></td><th>招聘人数：</th><td><%=hire.HireId!=0?hire.HireCount:""%></td></tr>
        </table>
        <div class="blank03"></div>
        <table style="width:100%; padding-left:20px; padding-right:20px;">
        <tr><th  style=" text-align:left; padding-left:20px;">职位描述</th></tr>
             
        </table>
        </div>
        <div class="newsdetail2-2-content" >
        <%=hire.HireId != 0 ? hire.Note : ""%>
        </div>
         <div class="enterprisedetail2-2-about">
          <table style="width:100%; padding-left:20px; padding-right:20px;">
        <tr><th  style=" text-align:left; padding-left:20px;">任职条件</th></tr>
             
        </table>
         </div>
          <div class="newsdetail2-2-content" >
       <%=hire.HireId!=0?hire.Conditions:""%>
        </div>
        <div class="enterprisedetail2-2-about">
       
        <div class="blank02"></div>
         <div class="blank02"></div>
         <div style="text-align:center;">
<asp:ImageButton ID="ibtnAdd" runat="server" CssClass="mybutton" ImageUrl="~/images/sq.png" 
               OnClientClick="return confirm('确定要申请该职位吗？申请后不可以删除。')"  onclick="ibtnAdd_Click" />&nbsp;<a href="enterprisedetail.aspx?id=<%=hire.EnterpriseId%>">该企业其它职位</a>&nbsp;
             </div>
             <fieldset id="divSend" style="display:none; height:80px; ">
             <legend style="text-align:left;"><a href="#" onclick="document.getElementById('divSend').style.display='none';">关闭</a></legend>
             私信内容：<textarea id="txtContent" runat="server" cols="20" rows="2" style="width:300px; height:60px;"></textarea><asp:Button ID="btnSend"
                 runat="server" Text="发送" OnClientClick="return check()" onclick="btnSend_Click" />
            
             </fieldset>

          <div class="blank02"></div>
           <div class="blank02"></div>
        <table style="width:100%; padding-left:20px; padding-right:20px;">
        <tr><th  style=" text-align:left; padding-left:20px;">企业简介</th></tr>
             
        </table>
        </div>
          <div class="newsdetail2-2-content" >
   <%=BLL.EnterpriseBLL.GetIdByEnterprise(hire.EnterpriseId).Note%>
        </div>
        
        </div>
        <div class="blank06">
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