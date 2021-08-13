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

public partial class enterprisedetail : System.Web.UI.Page
{
   public Enterprise ep = new Enterprise();

   public Users users = new Users();
   protected void Page_Load(object sender, EventArgs e)
   {
       if (Session["Users"] != null)
       {
           users = (Users)Session["Users"];
       }
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                ep = EnterpriseBLL.GetIdByEnterprise(Convert.ToInt32(Request.QueryString["id"]));
                DateTime dtNowTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                rpView.DataSource = HireBLL.AllData(" and EnterpriseId=" + ep.EnterpriseId + " and (ReleaseTime<='" + dtNowTime + "' and CutTime>='" + dtNowTime + "') order by ReleaseTime desc");
                rpView.DataBind();

            }
        }
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            Info info = new Info();
            Enterprise hi = EnterpriseBLL.GetIdByEnterprise(Convert.ToInt32(Request.QueryString["id"]));
            info.EnterpriseId = hi.EnterpriseId;
            info.InfoContent = txtContent.Value;
            info.UserId = users.UserId;
            info.InfoTime = DateTime.Now;
            info.InfoType = 0;
            InfoBLL.AddInfo(info);
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发送成功！');window.location.replace('enterprisedetail.aspx?id=" + Request.QueryString["id"] + "');</script>");
            return;
        }
        else if (Session["Enterprise"] != null)
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您不是求职者，无法发私信！');parent.window.location.href='enterprisedetail.aspx?id=" + Request.QueryString["id"] + "'</script>");
            return;
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请选登录后才可发私信！');parent.window.location.href='index.aspx'</script>");
            return;
        }
    }
}
