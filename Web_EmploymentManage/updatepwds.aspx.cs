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
    public Enterprise enterprise = new Enterprise();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Enterprise"] != null)
        {
            enterprise = (Enterprise)Session["Enterprise"];
        }
        else
        {
            enterprise = null;
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>parent.window.location.href='index.aspx'</script>");
            return;
        }

    }
    protected void lnkbOut_Click(object sender, EventArgs e)
    {
        
            Session["Enterprise"] = null;
            Response.Write("<script>parent.window.location.href='index.aspx'</script>");
      
    }
    protected void bntUpdatePwd_Click(object sender, EventArgs e)
    {
     
        if (Session["Enterprise"] != null)
        {
            Enterprise enterprise = (Enterprise)Session["Enterprise"];
            if (enterprise.Pwd != txtOldPwd.Value.Trim())
            {
                txtOldPwd.Focus();
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('旧密码错误！');</script>");
                return;

            }
            else
            {
                enterprise.Pwd = txtNewPwd.Value.Trim();
                if (EnterpriseBLL.UpdateEnterprise(enterprise) > 0)
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
