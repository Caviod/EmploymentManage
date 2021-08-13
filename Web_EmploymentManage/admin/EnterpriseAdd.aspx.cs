using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class admin_EnterpriseAdd : System.Web.UI.Page
{
    public string strNav = "企业信息详细";
    public Admin admin = new Admin();
    public Enterprise model=new Enterprise ();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] != null)
        {
            admin = (Admin)Session["Admin"];
        }
        else
        {
            admin = null;
            Response.Write("<script>parent.window.location.href='Login.aspx'</script>");
        }
        if (!IsPostBack)
        {
           
            
        
            if (Request.QueryString["id"] != null)
            {

                model = EnterpriseBLL.GetIdByEnterprise(Convert.ToInt32(Request.QueryString["id"]));
              

            }

        }
    }








   
}
