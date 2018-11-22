using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Notes.BusinessLayel;
using Notes.DataLayer;

namespace Notes
{

    public partial class frmNotes : System.Web.UI.Page
    {
        MessagingDAL DA = new MessagingDAL();
        clsNotes notes = new clsNotes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RefreshData();
            }
        }
        public void RefreshData()
        {
            gvNotes.DataSource = DA.GetNotesData();
            gvNotes.DataBind();
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string UserId= Session["UserId"].ToString();
            notes.Mode = "INSERT";
            notes.Userid =Convert.ToInt32(UserId);
            notes.Title = txtTitle.Text;
            notes.Body = txtBody.Text;
            bool status = DA.InsertNotes(notes);
            clear();
            RefreshData();


        }
        public void clear()
        {
            txtTitle.Text = "";
            txtBody.Text = "";
        }
    }
}