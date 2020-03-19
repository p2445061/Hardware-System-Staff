using System;
using System.Collections.Generic;

namespace HardwareClasses
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //todo ig
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name",mThisStaff.Name);
            DB.AddParameter("@Address",mThisStaff.Address);
            DB.AddParameter("@DOB",mThisStaff.DOB);
            DB.AddParameter("@Manager",mThisStaff.Manager);
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID",mThisStaff.ID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID",mThisStaff.ID);
            DB.AddParameter("@Name",mThisStaff.Name);
            DB.AddParameter("@Address",mThisStaff.Address);
            DB.AddParameter("@DOB",mThisStaff.DOB);
            DB.AddParameter("@Manager",mThisStaff.Manager);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByName(String name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name",name);
            DB.Execute("sproc_tblStaff_FilterByName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount = 0;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff staff = new clsStaff();
                staff.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                staff.Name = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                staff.Address = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                staff.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDOB"]);
                staff.Manager = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffManager"]);
                mStaffList.Add(staff);
                Index++;
            }
        }

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }
    }
}