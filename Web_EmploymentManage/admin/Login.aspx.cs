using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Model;
using BLL;

public partial class admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        Admin admin = new Admin();
        HttpCookie cookies = Request.Cookies["validate"];
        if (this.txtU_Check.Value.Trim() == cookies.Value)
        {
            if (AdminBLL.GetUsersLogin(this.txtU_Name.Value.Trim(), this.txtU_Pass.Value.Trim(), out admin))
            {
                Session["Admin"] = admin;
                Response.Redirect("index.aspx");
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名或者密码错误！');</script>");
                return;
            }
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('验证码错误！');</script>");
            return;
        }
    }
}
