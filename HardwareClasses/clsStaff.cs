using System;

namespace HardwareClasses
{
    public class clsStaff
    {
        private string mName;
        private DateTime mDOB;
        private string mAddress;
        private bool mManager;
        private int mID;

        public bool Manager
        {
            get
            {
                return mManager;
            }
            set
            {
                mManager = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }
        public string Address
        {
            get
            {
                return mAddress;
            }

            set
            {
                mAddress = value;
            }
        }
        public string Name
        {

            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public int ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public bool Find(int ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID", ID);
            DB.Execute("sproc_tblStaff_FilterByID");
            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                mManager = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffManager"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string ID, string Name, string Address, string DOB, string Manager)
        {
            string Error = "";

            if (Name.Length == 0)
            {
                Error += "The name may not be blank : ";
            }
            if (Name.Length > 50)
            {
                Error += "The name must be less than 51 characters : ";
            }
            if (Address.Length == 0)
            {
                Error += "The address may not be blank : ";
            }
            if (Address.Length > 50)
            {
                Error += "The address must be less than 51 characters : ";
            }
            try
            {
                DateTime DateTemp = Convert.ToDateTime(DOB);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error += "The date was not a valid date : ";
            }
            return Error;
        }
    }
}