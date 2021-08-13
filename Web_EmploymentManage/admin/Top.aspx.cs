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

public partial class admin_Top : System.Web.UI.Page
{
    public Admin admin = new Admin();
    public string adminName = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Admin"] != null)
        {
            admin = (Admin)Session["Admin"];
            adminName = admin.AdminName;
        }
        else
        {
            Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
        }
    }

    protected void LBQuit_Click(object sender, EventArgs e)
    {
        Session["Admin"] = null;
        Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
    }
}
