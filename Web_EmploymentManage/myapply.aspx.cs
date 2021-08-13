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

public partial class myapply : System.Web.UI.Page
{
    public string strWhere = "";
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
        if (!IsPostBack)
        {
            InitData(UcfarPager1.CurrentPageIndex);
        }
    }



    private void InitData(int pageIndex)
    {

        strWhere += " and UserId="+users.UserId;
        this.UcfarPager1.RecordCount = ApplyBLL.CountNumber(strWhere);


        rpView.DataSource = ApplyBLL.PageSelectApply(UcfarPager1.PageSize, pageIndex, strWhere, "ApplyTime", "desc");
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
        Session["Users"] = null;
        Response.Write("<script>parent.window.location.href='index.aspx'</script>");
    }
}
