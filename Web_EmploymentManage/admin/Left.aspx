<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="admin_Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>主页左边</title>
    
    <script src="JavaScript/prototype.lite.js" type="text/javascript"></script>

    <script src="JavaScript/moo.fx.js" type="text/javascript"></script>

    <script src="JavaScript/moo.fx.pack.js" type="text/javascript"></script>
     <style type="text/css">
        body
        {
            font: 12px Arial, Helvetica, sans-serif;
            color: #000;
            background-color: #ffffff;
            margin: 0px;
        }
        #container
        {
            width: 182px;
        }
        H1
        {
            font-size: 12px;
            margin: 0px;
            width: 182px;
            cursor: pointer;
            height: 30px;
            line-height: 20px;
        }
        H1 a
        {
            display: block;
            width: 182px;
            color: #51bde6;
            height: 30px;
            text-decoration: none;
            moz-outline-style: none;
            background-image: url(image/menu_bgs.gif);
            background-repeat: no-repeat;
            line-height: 30px;
            text-align: center;
            margin: 0px;
            padding: 0px;
        }
        .content
        {
            width: 182px;
            height: 26px;
        }
        .MM ul
        {
            list-style-type: none;
            margin: 0px;
            padding: 0px;
            display: block;
        }
        .MM li
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            list-style-type: none;
            display: block;
            text-decoration: none;
            height: 26px;
            width: 182px;
            padding-left: 0px;
        }
        .MM
        {
            width: 182px;
            margin: 0px;
            padding: 0px;
            left: 0px;
            top: 0px;
            right: 0px;
            bottom: 0px;
            clip: rect(0px,0px,0px,0px);
        }
        .MM a:link
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            background-image: url(image/menu_bg1.gif);
            background-repeat: no-repeat;
            height: 26px;
            width: 182px;
            display: block;
            text-align: center;
            margin: 0px;
            padding: 0px;
            overflow: hidden;
            text-decoration: none;
        }
        .MM a:visited
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            background-image: url(image/menu_bg1.gif);
            background-repeat: no-repeat;
            display: block;
            text-align: center;
            margin: 0px;
            padding: 0px;
            height: 26px;
            width: 182px;
            text-decoration: none;
        }
        .MM a:active
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            background-image: url(image/menu_bg1.gif);
            background-repeat: no-repeat;
            height: 26px;
            width: 182px;
            display: block;
            text-align: center;
            margin: 0px;
            padding: 0px;
            overflow: hidden;
            text-decoration: none;
        }
        .MM a:hover
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            font-weight: bold;
            color: #000000;
            
            background-repeat: no-repeat;
            text-align: center;
            display: block;
            margin: 0px;
            padding: 0px;
            height: 26px;
            width: 182px;
            text-decoration: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
    <table width="100%" height="280" border="0" cellpadding="0" cellspacing="0" bgcolor="white">
        <tr>
            <td width="182" valign="top">
                <div id="container">
                
                <h1 class="type">
                        <a href="javascript:void(0)">大学生信息管理</a></h1>
                    <div class="content">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="image/menu_topline.gif" width="182" height="5" alt="" />
                                </td>
                            </tr>
                        </table>
                        <ul class="MM">
                            <li><a href="UsersManage.aspx" target="main">查看大学生信息</a></li>                  
                        </ul>
                    </div>
                 
                
                    <h1 class="type">
                        <a href="javascript:void(0)">企业信息管理</a></h1>
                    <div class="content">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="image/menu_topline.gif" width="182" height="5" alt="" />
                                </td>
                            </tr>
                        </table>
                        <ul class="MM">
                            <li><a href="EnterpriseManage.aspx" target="main">查看企业信息</a></li>
                        </ul>
                    </div>
                    
                    
                       <h1 class="type">
                        <a href="javascript:void(0)">招聘信息管理</a></h1>
                    <div class="content">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="image/menu_topline.gif" width="182" height="5" alt="" />
                                </td>
                            </tr>
                        </table>
                        <ul class="MM">
                            <li><a href="HireManage.aspx" target="main">查看招聘信息</a></li>
                          
                        </ul>
                    </div>
                    
                    <h1 class="type">
                        <a href="javascript:void(0)">新闻管理</a></h1>
                    <div class="content">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="image/menu_topline.gif" width="182" height="5" alt="" />
                                </td>
                            </tr>
                        </table>
                        <ul class="MM"> 
                            
                            <li><a href="NewsAdd.aspx" target="main">添加新闻</a></li>
                            <li><a href="NewsManage.aspx" target="main">查看新闻</a></li>
                           
                               
                        </ul>
                    </div>
                    <%-- <h1 class="type">
                        <a href="javascript:void(0)">留言管理</a></h1>
                    <div class="content">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="image/menu_topline.gif" width="182" height="5" alt="" />
                                </td>
                            </tr>
                        </table>
                        <ul class="MM"> 
                            <li><a href="MessageManage.aspx" target="main">查看留言</a></li>
                           
                               
                        </ul>
                    </div>--%>
                    <h1 class="type">
                        <a href="javascript:void(0)">系统管理</a></h1>
                    <div class="content">
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <img src="image/menu_topline.gif" width="182" height="5" />
                                </td>
                            </tr>
                        </table>
                        <ul class="MM">
                            <li><a href="UpdatePwd.aspx" target="main">修改密码</a></li>
                       
                        </ul>
                    </div>
                    </div>
                   

                <script type="text/javascript">
		var contents = document.getElementsByClassName('content');
		var toggles = document.getElementsByClassName('type');
	
		var myAccordion = new fx.Accordion(
			toggles, contents, {opacity: true, duration: 400}
		);
		myAccordion.showThisHideOpen(contents[0]);
                </script>

            </td>
        </tr>
    </table>
    </form>
</body>
</html>
