using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class admin_HireAdd : System.Web.UI.Page
{
    public string strNav = "招聘信息详细";
    public Admin admin = new Admin();
    public Hire model = new Hire();
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
               model = HireBLL.GetIdByHire(Convert.ToInt32(Request.QueryString["id"]));
               

            }

        }
    }








   
}
