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

public partial class newsdetail : System.Web.UI.Page
{
    public News ns = new News();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                ns = NewsBLL.GetIdByNews(Convert.ToInt32(Request.QueryString["id"]));
            }
        }
    }
}
