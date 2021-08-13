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

public partial class enterprisecenter : System.Web.UI.Page
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
        if (!IsPostBack)
        {

            Enterprise model = EnterpriseBLL.GetIdByEnterprise(enterprise.EnterpriseId);
            if (model != null && model.EnterpriseId != 0)
            {

                txtAddress.Value = model.Address.Trim();
                txtEmail.Value = model.Email.Trim();
                txtEnterpriseName.Value = model.EnterpriseName.Trim();
                txtEnterpriseNo.Value = model.EnterpriseNo.Trim();
                txtMoneys.Value = model.Moneys.ToString().Trim()!="0"?model.Moneys.ToString().Trim():"";
                txtSetUpTime.Value = model.SetUpTime.Trim();
                ddlIndustry.SelectedValue = model.Industry.Trim();
                ddlNature.SelectedValue = model.Nature.Trim();
                ddlSizes.SelectedValue = model.Sizes.Trim();
                myEditor.Value = model.Note;
                lblUserName.Text = model.UserName;

            }
        }

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Enterprise model = EnterpriseBLL.GetIdByEnterprise(enterprise.EnterpriseId);


        model.Address = txtAddress.Value.Trim();
        model.Email = txtEmail.Value.Trim();
        model.EnterpriseName = txtEnterpriseName.Value.Trim();
        model.EnterpriseNo = txtEnterpriseNo.Value.Trim();
        model.Industry = ddlIndustry.SelectedValue;
        model.Moneys = Convert.ToInt32(txtMoneys.Value.Trim());
        model.Nature = ddlNature.SelectedValue;
        model.Note = myEditor.Value;
        model.SetUpTime = txtSetUpTime.Value.Trim();
        model.Sizes = ddlSizes.SelectedValue;



        if (EnterpriseBLL.UpdateEnterprise(model) > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');location=location;</script>");
            return;
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');</script>");
            return;
        }
    }

    protected void lnkbOut_Click(object sender, EventArgs e)
    {
        Session["Enterprise"] = null;
        Response.Write("<script>parent.window.location.href='index.aspx'</script>");
    }
}
