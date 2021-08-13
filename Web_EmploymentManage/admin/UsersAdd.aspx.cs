using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

public partial class admin_UsersAdd : System.Web.UI.Page
{
    public string strNav = "大学生信息详细";
    public Admin admin = new Admin();
    public Users model = new Users();
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

                model = UsersBLL.GetIdByUsers(Convert.ToInt32(Request.QueryString["id"]));
                //if (model != null && model.UserId != 0)
                //{
                //    txtAge.Value = ;
                 
                //    txtColleges.Value = ;
                //    txtEducation.Value = ;
                //    txtEmail.Value = ;
                //    txtIdCard.Value =;
                //    txtIsEmployment.Value =;
                //    txtMajor.Value = ;
                //    txtPhone.Value =;
                //    txtPolitical.Value = ;
                //    txtPwd.Value = ;
                //    txtRealName.Value =;


                //    txtSex.Value = ;
                //    myEditor.Value = ;
                //    txtUserName.Value =;
                //    txtRegisteredTime.Value = ;
                //    if (model.HeadImg != null && != "")
                //    {
                //       
                //    }

                   
                //    txtAddress.Value =;
                //    txtBirth.Value = ;
                //    txtExperience.Value = ;
                //    txtPenetration.Value = ;
                //    txtGraduationTime.Value = ;
                   
                //}

            }

        }
    }








   
}
