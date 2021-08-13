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

public partial class hireadd : System.Web.UI.Page
{
    public string dh = "发布招聘信息";
   public Enterprise enterprise = new Enterprise();
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
           txtReleaseTime.Value = DateTime.Now.ToString("yyyy-MM-dd");

           if (Request.QueryString["id"] != null)
           {
               Hire model = HireBLL.GetIdByHire(Convert.ToInt32(Request.QueryString["id"]));
               if (model != null && model.HireId != 0)
               {
                   txtAddress.Value = model.Address.Trim();
                   txtCutTime.Value = model.CutTime.ToString("yyyy-MM-dd");
                   txtHireCount.Value = model.HireCount.Trim();
                   txtJob.Value = model.Job.Trim();
                   txtReleaseTime.Value = model.ReleaseTime.ToString("yyyy-MM-dd");
                   ddlAge.SelectedValue = model.Age;
                   ddlEducation.SelectedValue = model.Education;
                   ddlExperience.SelectedValue = model.Experience;
                   ddlJobType.SelectedValue = model.JobType;
                   ddlSex.SelectedValue = model.Sex;
                   ddlTreatment.SelectedValue = model.Treatment;
                   myEditor.Value = model.Note;
                   myEditor2.Value = model.Conditions;
               }
               btnAdd.Text = "修改";
               dh = "修改招聘信息";
           }
       }

   }

    protected void lnkbOut_Click(object sender, EventArgs e)
    {
        Session["Enterprise"] = null;
        Response.Write("<script>parent.window.location.href='index.aspx'</script>");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (btnAdd.Text == "发布")
        {
            Hire model = new Hire();
            model.Address = txtAddress.Value.Trim();
            model.Age = ddlAge.SelectedValue;
            model.Conditions = myEditor2.Value;
            model.CutTime = Convert.ToDateTime(txtCutTime.Value);
            model.Education = ddlEducation.SelectedValue;
            model.EnterpriseId = enterprise.EnterpriseId;
            model.Experience = ddlExperience.SelectedValue;
            model.HireCount = txtHireCount.Value.Trim();
            model.Job = txtJob.Value.Trim();
            model.JobType = ddlJobType.SelectedValue;
            model.Note = myEditor.Value;
            model.ReleaseTime = Convert.ToDateTime(txtReleaseTime.Value);
            model.Sex = ddlSex.SelectedValue;
            model.Treatment = ddlTreatment.SelectedValue;

            if (HireBLL.AddHire(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发布成功！');window.location.replace('hiremanage.aspx');</script>");
                return;
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发布失败！');</script>");
                return;
            }
        }
        else
        {
            Hire model = HireBLL.GetIdByHire(Convert.ToInt32(Request.QueryString["id"]));
            model.Address = txtAddress.Value.Trim();
            model.Age = ddlAge.SelectedValue;
            model.Conditions = myEditor2.Value;
            model.CutTime = Convert.ToDateTime(txtCutTime.Value);
            model.Education = ddlEducation.SelectedValue;
            model.Experience = ddlExperience.SelectedValue;
            model.HireCount = txtHireCount.Value.Trim();
            model.Job = txtJob.Value.Trim();
            model.JobType = ddlJobType.SelectedValue;
            model.Note = myEditor.Value;
            model.ReleaseTime = Convert.ToDateTime(txtReleaseTime.Value);
            model.Sex = ddlSex.SelectedValue;
            model.Treatment = ddlTreatment.SelectedValue;

            if (HireBLL.UpdateHire(model) > 0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.replace('hiremanage.aspx');</script>");
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
