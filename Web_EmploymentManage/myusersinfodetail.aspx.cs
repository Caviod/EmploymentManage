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

public partial class myusersinfodetail : System.Web.UI.Page
{
    public Info model = new Info();
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
            if (Request.QueryString["id"] != null)
            {
                model = InfoBLL.GetIdByInfo(Convert.ToInt32(Request.QueryString["id"]));
            }
            Binds();
        }
    }

    private void Binds()
    {
        rpView.DataSource = InfoFollowBLL.AllData(" and InfoId=" + Request.QueryString["id"] + " order by FollowTime asc");
        rpView.DataBind();
    }



   
    protected void lnkbOut_Click(object sender, EventArgs e)
    {
        Session["Users"] = null;
        Response.Write("<script>parent.window.location.href='index.aspx'</script>");
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        InfoFollow inlo = new InfoFollow();
        inlo.FollowType = 0;//0为求职者
        inlo.FollowContent = txtContent.Value;
        inlo.FollowId = users.UserId;
        inlo.FollowTime = DateTime.Now;
        inlo.InfoId=Convert.ToInt32(Request.QueryString["id"]);
        InfoFollowBLL.AddInfoFollow(inlo);
        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发送成功！');window.location.replace('myusersinfodetail.aspx?id=" + Request.QueryString["id"] + "');</script>");
        return;
    }
}
