using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hardware_Testing
{
    [TestClass]
    public class tstStaff
    {
        string ID = "1";
        string Name = "James";
        string Address = "40 Glenfield Road";
        string DOB = "" + DateTime.Now.Date;
        string Manager = "" + false;

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staff = new clsStaff();

            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void ManagerPropertyOK()
        {
            clsStaff staff = new clsStaff();
            Boolean TestData = true;
            staff.Manager = TestData;
            Assert.AreEqual(staff.Manager, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            clsStaff staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            staff.DOB = TestData;
            Assert.AreEqual(staff.DOB, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "";
            staff.Address = TestData;
            Assert.AreEqual(staff.Address, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "";
            staff.Name = TestData;
            Assert.AreEqual(staff.Name, TestData);
        }

        [TestMethod]
        public void IDPropertyOK()
        {
            clsStaff staff = new clsStaff();
            int TestData = 1;
            staff.ID = TestData;
            Assert.AreEqual(staff.ID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            int id = 1;
            staff.ID = id;
            Found = staff.Find(id);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int id = 1;
            staff.ID = id;
            Found = staff.Find(id);
            if (staff.Name != "James Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int id = 1;
            staff.ID = id;
            Found = staff.Find(id);
            if (staff.DOB != Convert.ToDateTime("4/12/1999"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int id = 1;
            staff.ID = id;
            Found = staff.Find(id);
            if (staff.Address != "40 Glenfield Road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIDFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int id = 1;
            staff.ID = id;
            Found = staff.Find(id);
            if (staff.ID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestManagerFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int id = 1;
            staff.ID = id;
            Found = staff.Find(id);
            if (staff.Manager != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        //name

        [TestMethod]
        public void NameMinLessOne()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Name = "";
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Name = "a";
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Name = "aa";
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Name = "";
            Name = Name.PadRight(49,'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Name = "";
            Name = Name.PadRight(50, 'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Name = "";
            Name = Name.PadRight(51, 'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Name = "";
            Name = Name.PadRight(25, 'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameEXMax()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Name = "";
            Name = Name.PadRight(500, 'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreNotEqual(Error, "");
        }

        //address

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Address = "";
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Address = "a";
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Address = "aa";
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Address = "";
            Address = Address.PadRight(49, 'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Address = "";
            Address = Address.PadRight(50, 'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Address = "";
            Address = Address.PadRight(51, 'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Address = "";
            Address = Address.PadRight(25, 'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressEXMax()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            Address = "";
            Address = Address.PadRight(500, 'a');
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreNotEqual(Error, "");
        }

        //dob

        [TestMethod]
        public void DOBEXMin()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            DOB = TestDate.ToString();
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            DOB = TestDate.ToString();
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMax()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            DOB = TestDate.ToString();
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxPlusOne()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            DOB = TestDate.ToString();
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBEXMax()
        {
            clsStaff staff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            DOB = TestDate.ToString();
            Error = staff.Valid(ID, Name, Address, DOB, Manager);
            Assert.AreNotEqual(Error, "");
        }
    }
}
