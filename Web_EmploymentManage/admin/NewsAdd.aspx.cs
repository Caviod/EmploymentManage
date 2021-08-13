using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class admin_NewsAdd : System.Web.UI.Page
{
    public string strNav = "添加新闻";
    public Admin admin = new Admin();
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
            txtNewsTime.Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
        
            if (Request.QueryString["id"] != null)
            {

                News model = NewsBLL.GetIdByNews(Convert.ToInt32(Request.QueryString["id"]));
                if (model != null && model.NewsId != 0)
                {

                    txtNewsAuthor.Value = model.Author.Trim();
                    myEditor.Value = model.NewsContent.Trim();

                   txtNewsTitle.Value   = model.NewsTitle.Trim();
                    txtSource.Value = model.Source.Trim();
                    txtNewsTime.Value = model.ReleaseTime.ToString("yyyy-MM-dd HH:mm:ss").Trim();


                }
                strNav = "修改新闻";
                btnUpdate.Text = "修改";

            }

        }
    }








    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (btnUpdate.Text == "添加")
        {

            News model = new News();
            model.Author = txtNewsAuthor.Value.Trim();
            model.NewsContent = myEditor.Value;
            model.NewsTitle = txtNewsTitle.Value;
            model.ReleaseTime = Convert.ToDateTime(txtNewsTime.Value);
            model.Source = txtSource.Value.Trim();

            if (NewsBLL.AddNews(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加成功！');window.location.replace('NewsManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('添加失败！');</script>");
                return;
            }


        }
        else
        {
            News model = NewsBLL.GetIdByNews(Convert.ToInt32(Request.QueryString["id"]));
            model.Author = txtNewsAuthor.Value.Trim();
            model.NewsContent = myEditor.Value;
            model.NewsTitle = txtNewsTitle.Value;
            model.ReleaseTime = Convert.ToDateTime(txtNewsTime.Value);
            model.Source = txtSource.Value.Trim();





            if (NewsBLL.UpdateNews(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('NewsManage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');</script>");
                return;
            }

        }
    }
}
