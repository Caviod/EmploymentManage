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
using System.IO;

public partial class userscenter : System.Web.UI.Page
{
    public Users users = new Users();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Users"] != null)
        {
            users = (Users)Session["Users"];
        }
        else
        {
            users = null;
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>parent.window.location.href='index.aspx'</script>");
            return;
        }
        if (!IsPostBack)
        {

            Users model = UsersBLL.GetIdByUsers(users.UserId);
            if (model != null && model.UserId != 0)
            {

                txtAge.Value = model.Age != 0 ? model.Age.ToString() : "";
                //txtColleges.Value = model.Colleges.Trim();
                //txtEmail.Value = model.Email.Trim();
                //txtIdCard.Value = model.IdCard.Trim();
                txtMajor.Value = model.Major.Trim();
                txtPhone.Value = model.Phone.Trim();
                txtRealName.Value = model.RealName.Trim();
                ddlEducation.SelectedValue = model.Education.Trim();
                ddlIsEmployment.SelectedValue = model.IsEmployment.Trim();
                ddlPolitical.SelectedValue=model.Political.Trim();
                ddlSex.SelectedValue=model.Sex.Trim();
                lblUserName.Text=model.UserName.Trim();
                //myEditor.Value=model.Introduce;
                if (model.HeadImg != null && model.HeadImg != "")
                {
                    //imgPicture.Src = model.HeadImg;
                }

                //txtAddress.Value = model.Address.Trim();
                txtBirth.Value = model.Birth.ToString("yyyy-MM-dd") != "1900-01-01" ? model.Birth.ToString("yyyy-MM-dd") : "";

                //ddlExperience.SelectedValue = model.Experience.Trim();
                //txtPenetration.Value = model.Penetration.Trim();
                txtGraduationTime.Value = model.GraduationTime.Trim();


            }
        }

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Users model = UsersBLL.GetIdByUsers(users.UserId);


        model.Email = txtEmail.Value.Trim();
        model.Age = Convert.ToInt32(txtAge.Value);
        //model.Colleges = txtColleges.Value.Trim();
        model.Education = ddlEducation.SelectedValue;
       // model.IdCard = txtIdCard.Value.Trim();
       //model.Introduce = myEditor.Value;
        model.IsEmployment = ddlIsEmployment.SelectedValue;
        model.Major = txtMajor.Value.Trim();
        model.Phone = txtPhone.Value.Trim();
        model.Political = ddlPolitical.SelectedValue;
        model.RealName = txtRealName.Value.Trim();
        model.Sex = ddlSex.SelectedValue;
        model.GraduationTime = txtGraduationTime.Value.Trim();
       //model.Experience = ddlExperience.SelectedValue;
       //model.Address = txtAddress.Value.Trim();
        model.Birth = Convert.ToDateTime(txtBirth.Value);
        //model.Penetration = txtPenetration.Value.Trim();
  
        string img = "";
        //if (fupPhoto.PostedFile.FileName != "")
        //{

        //    if (model.UserId != 0)
        //    {
        //        if (model.HeadImg.IndexOf("admin") != -1)
        //        {
        //            string strImgUrl = model.HeadImg.Substring(model.HeadImg.IndexOf("admin"));
        //            string path = Server.MapPath(Request.ApplicationPath) + "\\" + strImgUrl.Replace("/", "\\");

        //            if (System.IO.File.Exists(path))
        //            {
        //                System.IO.File.Delete(path);
        //            }
        //        }
        //    }

        //    string strpath = @"~/admin/UpLoad/Images/";
        //    img = DateTime.Now.ToString("yyyyMMddHHmmss") + System.IO.Path.GetExtension(fupPhoto.PostedFile.FileName);//把图片重命名

        //    if (!Directory.Exists(Server.MapPath(strpath)))
        //    {
        //        Directory.CreateDirectory(Server.MapPath(strpath));
        //    }

        //    //fupPhoto.PostedFile.SaveAs(Server.MapPath(strpath + img));
        //    model.HeadImg = "admin/UpLoad/Images/" + img;//"http://" + Request.Url.Authority +
        //}

       

        if (UsersBLL.UpdateUsers(model) > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('userscenter.aspx');</script>");
            return;
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改失败！');</script>");
            return;
        }
    }

    protected void lnkbOut_Click(object sender, EventArgs e)
    {
        Session["Users"] = null;
        Response.Write("<script>parent.window.location.href='index.aspx'</script>");
    }
}
