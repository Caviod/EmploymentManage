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
using System.Collections.Generic;

public partial class messagelist : System.Web.UI.Page
{
    public string whereSrc = "";
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
        }
    }

    //获取回复个数
    public string GetCount(object obj)
    {
        string str = "";
        str = BLL.ReplyBLL.CountNumber(" and MsgId =" + obj + "").ToString();
        return str;
    }


    private void InitData(int pageIndex)
    {
       
        this.UcfarPager1.RecordCount = MessageBLL.CountNumber("");

        rpView.DataSource = MessageBLL.PageSelectMessage(UcfarPager1.PageSize, pageIndex, "", "MsgTime", "desc");
        rpView.DataBind();
        if (rpView.Items.Count == 0)
       
        {
            UcfarPager1.Visible = false;
        }
        else
        {
        UcfarPager1.Visible=true;
        }
       

    }

    protected void UcfarPager1_PageChanged(object sender, EventArgs e)
    {

        InitData(UcfarPager1.CurrentPageIndex);
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Message model = new Message();

        model.MsgContent = txtMessageContent.Value.Trim();
        model.MsgTime = DateTime.Now;
        model.MsgTitle = txtMessageTitle.Value.Trim();

        if (Session["Users"] != null)
        {
            model.UserId = users.UserId;

            if (MessageBLL.AddMessage(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('留言成功！');window.location.replace('messagelist.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('留言失败！');</script>");
                return;
            }

        }
        else if (Session["Enterprise"] != null)
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您不是求职者，无法留言！');window.location.replace('messagelist.aspx');</script>");
            return;
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请先登录后才可留言！');window.location.replace('index.aspx');</script>");
            return;
        }





    }
}
