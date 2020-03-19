using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "ID";
        lstStaffList.DataValueField = "Name";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ID"] = -1;
        Response.Redirect("staff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int ID;
        if (lstStaffList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["ID"] = ID;
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int ID;
        if (lstStaffList.SelectedIndex != -1)
        {
            ID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["ID"] = ID;
            Response.Redirect("staff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ReportByName(txtfilter.Text);
        lstStaffList.DataSource = StaffList.StaffList;
        lstStaffList.DataValueField = "ID";
        lstStaffList.DataValueField = "Name";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ReportByName("");
        txtfilter.Text = "";
        lstStaffList.DataSource = StaffList.StaffList;
        lstStaffList.DataValueField = "ID";
        lstStaffList.DataValueField = "Name";
        lstStaffList.DataBind();
    }
}