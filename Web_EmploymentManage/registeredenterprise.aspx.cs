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

public partial class registeredenterprise : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Enterprise ep = new Enterprise();
        ep.Address = "";
        ep.Email = "";
        ep.EnterpriseName = txtEnterpriseName.Value.Trim();
        ep.EnterpriseNo = txtEnterpriseNo.Value.Trim();
        ep.Industry = ddlIndustry.SelectedValue.Trim();
        ep.Moneys = 0;
        ep.Nature = ddlNature.SelectedValue.Trim();
        ep.Note = "";
        ep.Pwd = txtSureNewPwd.Value.Trim();
        ep.RegisteredTime = DateTime.Now;
        ep.SetUpTime = "";
        ep.Sizes = ddlSizes.SelectedValue.Trim();
        ep.UserName = txtUserName.Value.Trim();
        if (EnterpriseBLL.IsTrue(ep.UserName))
        {

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该用户名已经存在，不能重复！');</script>");
            return;
        }
        else
        {
            if (EnterpriseBLL.AddEnterprise(ep) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册成功！');window.location.replace('index.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册失败！');</script>");
                return;
            }
        }
    }
}
