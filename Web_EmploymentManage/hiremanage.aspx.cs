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

public partial class hiremanage : System.Web.UI.Page
{
    public string strWhere = "";
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
            InitData(UcfarPager1.CurrentPageIndex);
        }
    }



    private void InitData(int pageIndex)
    {

        strWhere += " and EnterpriseId=" + enterprise.EnterpriseId;
        this.UcfarPager1.RecordCount = HireBLL.CountNumber(strWhere);


        rpView.DataSource = HireBLL.PageSelectHire(UcfarPager1.PageSize, pageIndex, strWhere, "ReleaseTime", "desc");
        rpView.DataBind();
        if (rpView.Items.Count != 0)
        {
            UcfarPager1.Visible = true;
        }
        else
        {
            UcfarPager1.Visible = false;
        }
    }

    protected void UcfarPager1_PageChanged(object sender, EventArgs e)
    {
        InitData(UcfarPager1.CurrentPageIndex);
    }
    protected void lnkbOut_Click(object sender, EventArgs e)
    {
        Session["Enterprise"] = null;
        Response.Write("<script>parent.window.location.href='index.aspx'</script>");
    }

    protected void lnkbDel_Click(object sender, EventArgs e)
    {
        LinkButton lnkbDel = (LinkButton)sender;

        if (HireBLL.DeleteHire(Convert.ToInt32(lnkbDel.CommandArgument)) > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除成功！');window.location.replace('hiremanage.aspx');</script>");
            return;
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除失败！');</script>");
            return;
        }

    }
}
