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

public partial class userslistall : System.Web.UI.Page
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

        if ( txtKey.Value.Trim().Length!=0)
        {
            strWhere += " and RealName like '%"+txtKey.Value.Trim()+"%'";
        }
        if (ddlSex.SelectedValue != "全部")
        {
            strWhere += " and Sex='" + ddlSex.SelectedValue + "'";
        }
        if (ddlEducation.SelectedValue != "全部")
        {
            strWhere += " and Education='" + ddlEducation.SelectedValue + "'";
        }
        this.UcfarPager1.RecordCount = UsersBLL.CountNumber(strWhere);


        rpView.DataSource = UsersBLL.PageSelectUsers(UcfarPager1.PageSize, pageIndex, strWhere, "RegisteredTime", "desc");
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


    /// <summary>
    /// 搜索
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        InitData(UcfarPager1.CurrentPageIndex);
    }
}
