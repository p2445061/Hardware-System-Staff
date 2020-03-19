using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;


    public partial class staff : System.Web.UI.Page
    {

        int ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(Session["ID"]);
            if (IsPostBack == false)
            {
                if (ID != -1)
                {
                   //DisplayStaff();
                }
            }
        }

        void DisplayStaff()
        {
            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff.Find(ID);
            txtID.Text = StaffList.ThisStaff.ID.ToString();
            txtName.Text = StaffList.ThisStaff.Name.ToString();
            txtAddress.Text = StaffList.ThisStaff.Address.ToString();
            txtDOB.Text = StaffList.ThisStaff.DOB.ToString();
            StaffManager.Checked = StaffList.ThisStaff.Manager;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
        clsStaff staff = new clsStaff();
        string ID = txtID.Text;
        string Name = txtName.Text;
        string Address = txtAddress.Text;
        string DOB = txtDOB.Text;
        string Manager = "" + StaffManager.Checked;

        string Error = "";
        Error = staff.Valid(ID, Name, Address, DOB, Manager);
        if (Error == "")
        {
            staff.ID = Convert.ToInt32(ID);
            staff.Name = Name;
            staff.Address = Address;
            staff.DOB = Convert.ToDateTime(DOB);
            staff.Manager = StaffManager.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            if (Convert.ToInt32(ID) == -1)
            {
                StaffList.ThisStaff = staff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(Convert.ToInt32(ID));
                StaffList.ThisStaff = staff;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();
        int ID;
        Boolean Found = false;
        ID = Convert.ToInt32(txtID.Text);
        Found = staff.Find(ID);
        if (Found)
        {
            txtID.Text = "" + staff.ID;
            txtAddress.Text = staff.Address;
            txtDOB.Text = "" + staff.DOB;
            StaffManager.Checked = staff.Manager;
        }
    }

    protected void btnCan_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}
