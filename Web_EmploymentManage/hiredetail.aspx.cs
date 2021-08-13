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

public partial class hiredetail : System.Web.UI.Page
{
    public Hire hire = new Hire();

    public Users users = new Users();
    public void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];
        }
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                hire = HireBLL.GetIdByHire(Convert.ToInt32(Request.QueryString["id"]));

            }
        }
    }

    protected void ibtnAdd_Click(object sender, ImageClickEventArgs e)
    {

        if (Session["Users"] != null)
        {
            if (ApplyBLL.GetIdByUserIdAndHireId(users.UserId, Convert.ToInt32(Request.QueryString["id"])).ApplyId == 0)
            {
                Apply app = new Apply();
                app.ApplyTime = DateTime.Now;
                app.HireId = Convert.ToInt32(Request.QueryString["id"]);
                app.State = "未阅读";
                app.UserId = users.UserId;
                ApplyBLL.AddApply(app);
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('已成功申请该职位！');parent.window.location.href='myapply.aspx'</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您已申请过该职位！');parent.window.location.href='myapply.aspx'</script>");
                return;
            }
        }
        else if (Session["Enterprise"]!=null)
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您不是求职者，无法申请！');parent.window.location.href='hiredetail.aspx?id=" + Request.QueryString["id"] + "'</script>");
            return;
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请选登录后才可申请！');parent.window.location.href='index.aspx'</script>");
            return;
        }
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            Info info = new Info();
            Hire hi = HireBLL.GetIdByHire(Convert.ToInt32(Request.QueryString["id"]));
            info.EnterpriseId = hi.EnterpriseId;
            info.InfoContent = txtContent.Value;
            info.UserId = users.UserId;
            info.InfoTime = DateTime.Now;
            info.InfoType = 0;
            InfoBLL.AddInfo(info);
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发送成功！');window.location.replace('hiredetail.aspx?id=" + Request.QueryString["id"] + "');</script>");
            return;
        }
        else if (Session["Enterprise"] != null)
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您不是求职者，无法发私信！');parent.window.location.href='hiredetail.aspx?id=" + Request.QueryString["id"] + "'</script>");
            return;
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请选登录后才可发私信！');parent.window.location.href='index.aspx'</script>");
            return;
        }
    }
}
