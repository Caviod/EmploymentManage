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

public partial class updatepwd : System.Web.UI.Page
{
    public Users users = new Users();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];
        }
        else
        {
            users = null;
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>parent.window.location.href='index.aspx'</script>");
            return;
        }

    }
    protected void lnkbOut_Click(object sender, EventArgs e)
    {
      
            Session["Users"] = null;
            Response.Write("<script>parent.window.location.href='index.aspx'</script>");
      
        
    }
    protected void bntUpdatePwd_Click(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            Users users = (Users)Session["Users"];
            if (users.Pwd != txtOldPwd.Value.Trim())
            {
                txtOldPwd.Focus();
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('旧密码错误！');</script>");
                return;

            }
            else
            {
                users.Pwd = txtNewPwd.Value.Trim();
                if (UsersBLL.UpdateUsers(users) > 0)
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改密码成功！\\n新密码为：" + txtNewPwd.Value.Trim() + "');location=location;</script>");
                    return;
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改密码失败！');</script>");
                    return;
                }
            }
        }
        
    }
}
