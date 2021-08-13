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

public partial class replylist : System.Web.UI.Page
{
    public string whereSrc = "";
    
    public Message msg = new Message();
    public Users users = new Users();
    public Enterprise enterprise = new Enterprise();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];
            lblUserName.Text = UsersBLL.GetIdByUsers(users.UserId).UserName;
        }
        else if (Session["Enterprise"] != null)
        {
            enterprise = (Enterprise)Session["Enterprise"];
            lblUserName.Text = EnterpriseBLL.GetIdByEnterprise(enterprise.EnterpriseId).UserName;
        }
        else
        {
            lblUserName.Text = "匿名网友";
        }

        if (!IsPostBack)
        {
            InitData(UcfarPager1.CurrentPageIndex);
            if (Request.QueryString["id"] != null)
            {
                msg = MessageBLL.GetIdByMessage(Convert.ToInt32(Request.QueryString["id"]));
            }
        }
    }




    private void InitData(int pageIndex)
    {

        this.UcfarPager1.RecordCount = ReplyBLL.CountNumber(" and MsgId=" + Request.QueryString["id"]);

        rpView.DataSource = ReplyBLL.PageSelectReply(UcfarPager1.PageSize, pageIndex, " and MsgId=" + Request.QueryString["id"], "ReplyTime", "desc");
       
        rpView.DataBind();

        if (rpView.Items.Count == 0)
        {
            UcfarPager1.Visible = false;
        }
        else
        {
            UcfarPager1.Visible = true;
        }
        

    }

    protected void UcfarPager1_PageChanged(object sender, EventArgs e)
    {

        InitData(UcfarPager1.CurrentPageIndex);
        if (Request.QueryString["id"] != null)
        {
            msg = MessageBLL.GetIdByMessage(Convert.ToInt32(Request.QueryString["id"]));
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Reply model = new Reply();

        model.ReplyContent = txtMessageContent.Value.Trim();
        model.ReplyTime = DateTime.Now;
        model.MsgId = Convert.ToInt32(Request.QueryString["id"]);

        if (Session["Users"] != null)
        {
            model.UserId = users.UserId;

            if (ReplyBLL.AddReply(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('回复成功！');window.location.replace('replylist.aspx?id=" + Request.QueryString["id"] + "');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('回复失败！');</script>");
                return;
            }

        }
        else if (Session["Enterprise"] != null)
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您不是求职者，无法回复！');window.location.replace('replylist.aspx?id=" + Request.QueryString["id"] + "');</script>");
            return;
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请先登录后才可回复！');window.location.replace('index.aspx');</script>");
            return;
        }





    }
    
}
