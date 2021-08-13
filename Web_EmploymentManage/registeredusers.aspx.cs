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

public partial class registeredusers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Users ep = new Users();
        ep.Age = 0;
        ep.Colleges = "";
        ep.Education = ddlEducation.SelectedValue.Trim();
        ep.Email = "";
        ep.HeadImg = "";
        ep.IdCard ="";
        ep.Introduce = "";
        ep.IsEmployment = "否";
        ep.Major = "";
        ep.Phone = "";
        ep.Political = "群众";
        ep.Pwd = txtSureNewPwd.Value.Trim();
        ep.RealName = txtRealName.Value.Trim();
        ep.RegisteredTime = DateTime.Now;
        ep.Sex = ddlSex.SelectedValue.Trim();
        ep.UserName = txtUserName.Value.Trim();
        ep.Experience = "应届毕业生";
        ep.GraduationTime = "";
        ep.Penetration = "";
        ep.Birth =Convert.ToDateTime("1900-01-01");
        ep.Address = "";
        if (UsersBLL.IsTrue(ep.UserName))
        {

            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('该用户名已经存在，不能重复！');</script>");
            return;
        }
        else
        {
            if (UsersBLL.AddUsers(ep) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册成功！');window.location.replace('index.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册失败！');</script>");
                return;
            }
        }
    }
}
