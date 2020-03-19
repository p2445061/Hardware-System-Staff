using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class DeleteStaff : System.Web.UI.Page
{

    Int32 ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        ID = Convert.ToInt32(Session["ID"]);
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ThisStaff.Find(ID);
        StaffList.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}