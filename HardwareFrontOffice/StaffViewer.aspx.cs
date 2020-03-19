using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();
        staff = (clsStaff)Session["staff"];
        Response.Write(staff.Name);
    }
}