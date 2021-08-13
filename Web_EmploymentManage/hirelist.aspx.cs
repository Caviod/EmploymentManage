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

public partial class hirelist : System.Web.UI.Page
{
    public string strWhere = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            InitData(UcfarPager1.CurrentPageIndex);
        }
    }



    private void InitData(int pageIndex)
    {


        if (txtKey.Value.Length != 0)
        {
            strWhere += string.Format(" and Job like '%{0}%'", txtKey.Value.Trim());
        }




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







    protected void btnSearch_Click(object sender, EventArgs e)
    {
        InitData(UcfarPager1.CurrentPageIndex);
    }
}
