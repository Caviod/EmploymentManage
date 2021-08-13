using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class admin_MessageManage : System.Web.UI.Page
{
    public string strWhere = "";
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
            int DataCount = MessageBLL.CountNumber(strWhere); //共多少条记录
            int hPageSize = (DataCount % Convert.ToInt32(HCount.Value)) != 0 ? DataCount / Convert.ToInt32(HCount.Value) + 1 : DataCount / Convert.ToInt32(HCount.Value);//共多少页
            HPageSize.Value = DataCount.ToString();
            HAllPage.Value = hPageSize.ToString();
            this.RpNews.DataSource = MessageBLL.PageSelectMessage(Convert.ToInt32(HCount.Value), Convert.ToInt32(HNowPage.Value), strWhere, "MsgTime", "desc");
            this.RpNews.DataBind();
            BindData("");
        }
    }
    //删除选中项
    protected void BtnAllDel_Click(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(HSelectID.Value.Trim()))
        {
            try
            {
                string a = HSelectID.Value.Trim();
                string[] b = a.Split(new char[] { ',' });
                int i = 0;
                foreach (string c in b)
                {
                    i++;

                    ReplyBLL.DeleteReplyByMsgId(Convert.ToInt32(c));

                    MessageBLL.DeleteMessage(Convert.ToInt32(c));
                }
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('已成功删除" + i + "条！');window.location.replace('MessageManage.aspx');</script>");
                return;
            }
            catch
            {

                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除失败,请与技术人员联系!');</script>");
                return;
            }
        }
    }
    //首页
    protected void LBHome_Click(object sender, EventArgs e)
    {
        BindData("");
    }
    //上一页
    protected void LBUp_Click(object sender, EventArgs e)
    {
        BindData("up");
    }
    //下一页
    protected void LBNext_Click(object sender, EventArgs e)
    {
        BindData("next");
    }
    //尾页
    protected void LBEnd_Click(object sender, EventArgs e)
    {
        BindData("end");
    }
    //分页查找
    private void BindData(string strClass)
    {
        int nowPage = 1;

        switch (strClass)
        {
            case "next":
                nowPage = Convert.ToInt32(HNowPage.Value) + 1;
                break;
            case "up":
                nowPage = Convert.ToInt32(HNowPage.Value) - 1;
                break;
            case "end":
                nowPage = Convert.ToInt32(HAllPage.Value);
                break;
            default:
                nowPage = 1;
                break;
        }

        if (Convert.ToInt32(HAllPage.Value) <= 1)
        {
            LBEnd.Enabled = false;
            LBHome.Enabled = false;
            LBNext.Enabled = false;
            LBUp.Enabled = false;
        }
        else if (nowPage == 1)
        {
            LBHome.Enabled = false;
            LBUp.Enabled = false;
            LBNext.Enabled = true;
            LBEnd.Enabled = true;
        }
        else if (nowPage == Convert.ToInt32(HAllPage.Value))
        {
            LBHome.Enabled = true;
            LBUp.Enabled = true;
            LBNext.Enabled = false;
            LBEnd.Enabled = false;
        }
        else
        {
            LBEnd.Enabled = true;
            LBHome.Enabled = true;
            LBNext.Enabled = true;
            LBUp.Enabled = true;
        }



        this.RpNews.DataSource = MessageBLL.PageSelectMessage(Convert.ToInt32(HCount.Value), nowPage, strWhere, "MsgTime", "desc");
        this.RpNews.DataBind();
        HNowPage.Value = nowPage.ToString();
        PageMes.Text = string.Format("[每页<font color=green>{0}</font>条 第<font color=red>{1}</font>页／共<font color=green>{2}</font>页   共<font color=green>{3}</font>条]", HCount.Value, nowPage.ToString(), HAllPage.Value, HPageSize.Value);

    }
    //删除
    protected void ibDel_ItemDeleting(object sender, EventArgs e)
    {
        try
        {
            int newsId = Convert.ToInt32((sender as ImageButton).CommandArgument);
            ReplyBLL.DeleteReplyByMsgId(newsId);
            MessageBLL.DeleteMessage(newsId);//删除类型
            Response.Write("<script>alert('删除成功！');window.location.replace('MessageManage.aspx');</script>");
        }
        catch
        {
            Response.Write("<script>alert('删除失败！');window.location.replace('MessageManage.aspx');</script>");
        }
    }
}
