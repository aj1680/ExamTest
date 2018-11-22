using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Notes.BusinessLayel;
using Notes.DataLayer;

namespace Notes.Forms
{
    public partial class frmUserLogin : System.Web.UI.Page
    {
        MessagingDAL DA = new MessagingDAL();
        clsUser user = new clsUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            user.UserName = txtUerName.Text;
            user.Password = txtPassword.Text;            
            Int32 status = DA.UserLogin(user);
           if(status>0)
            {
                Session["UserId"] = status;
                Response.Redirect("frmNotes.aspx");
            }
           else
            {
                Session["UserId"] = "-1";
                clear();
                Response.Redirect("frmUserLogin.aspx");
            }
        }
        public void clear()
        {
            txtUerName.Text = "";
            txtPassword.Text = "";
        }
    }
}