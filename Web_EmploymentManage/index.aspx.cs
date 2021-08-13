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

public partial class index : System.Web.UI.Page
{
    public List<News> listTop10 = new List<News>();//动态新闻前10条

    public Users users = new Users();//求职者

    public Enterprise enterprise = new Enterprise();//企业

    protected void Page_Load(object sender, EventArgs e)
    {
       

        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];
            
            tbLogin.Style.Add("display", "none");
            tbUsers.Style.Add("display", "block");
            tbEnterprise.Style.Add("display", "none");
            aUsers.InnerText = users.UserName;
            aUsers.HRef = "userscenter.aspx";
        }
        if (Session["Enterprise"] != null)
        {
            enterprise = (Enterprise)Session["Enterprise"];

            tbLogin.Style.Add("display", "none");
            tbUsers.Style.Add("display", "none");
            tbEnterprise.Style.Add("display", "block");
            aEnterprise.InnerText = enterprise.UserName;
            aEnterprise.HRef = "enterprisecenter.aspx";
            
        }
        if (!IsPostBack)
        {
            Binds();
        }
    }

    /// <summary>
    /// 加载绑定
    /// </summary>
    private void Binds()
    {
        listTop10 = NewsBLL.AllData(16, " order by ReleaseTime desc");
        DateTime dtNowTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
        rpView.DataSource = HireBLL.AllData(20, " and (ReleaseTime<='" + dtNowTime + "' and CutTime>='" + dtNowTime + "') order by ReleaseTime desc"); //最新岗位前15条
        rpView.DataBind();
    }
    /// <summary>
    /// 登录
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void btnLogin_Click(object sender, EventArgs e)
    {
        if (rdoUsers.Checked)
        {
            Users users = new Users();
            if (UsersBLL.GetUsersLogin(txtUserName.Value.Trim(), txtPwd.Value.Trim(), out users))
            {


                Session["Users"] = users;

                Response.Redirect("userscenter.aspx");


            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户或密码错误！');window.location.replace('index.aspx');</script>");
                return;
            }
        }
        else if (rdoEnterprise.Checked)
        {
            Enterprise enterprise = new Enterprise();
            if (EnterpriseBLL.GetUsersLogin(txtUserName.Value.Trim(), txtPwd.Value.Trim(), out enterprise))
            {


                Session["Enterprise"] = enterprise;

                Response.Redirect("enterprisecenter.aspx");


            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户或密码错误！');window.location.replace('index.aspx');</script>");
                return;
            }
        }
    }
    protected void lnkbUsersOut_Click(object sender, EventArgs e)
    {
        Session["Users"] = null;
        Response.Write("<script>parent.window.location.href='index.aspx'</script>");
    }
    protected void lnkbEnterpriseOut_Click(object sender, EventArgs e)
    {
        Session["Enterprise"] = null;
        Response.Write("<script>parent.window.location.href='index.aspx'</script>");
    }
}
