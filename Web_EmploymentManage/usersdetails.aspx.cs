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


public partial class usersdetails : System.Web.UI.Page
{
    public Enterprise enterprise = new Enterprise();
    public Users model = new Users();
   
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
            if (Request.QueryString["id"] != null)
            {
                model = UsersBLL.GetIdByUsers(Convert.ToInt32(Request.QueryString["id"]));
          
            }
        }
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        Info info = new Info();
        info.EnterpriseId = enterprise.EnterpriseId;
        info.InfoContent = txtContent.Value;
        info.UserId = Convert.ToInt32(Request.QueryString["id"]);
        info.InfoTime = DateTime.Now;
        info.InfoType = 1;
        InfoBLL.AddInfo(info);
        txtContent.Value = "";
        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发送成功！');window.location.replace('userslistall.aspx');</script>");
        return;

    }
    protected void lnkbOut_Click(object sender, EventArgs e)
    {

        Session["Enterprise"] = null;
        Response.Write("<script>parent.window.location.href='index.aspx'</script>");
    }
   
}
