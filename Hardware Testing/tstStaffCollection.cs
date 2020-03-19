using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hardware_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.ID = 1;
            TestItem.Name = "James";
            TestItem.Address = "40 Glenfield Road";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Manager = false;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.ID = 1;
            TestStaff.Name = "James";
            TestStaff.Address = "40 Glenfield Road";
            TestStaff.DOB = DateTime.Now.Date;
            TestStaff.Manager = false;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.ID = 1;
            TestItem.Name = "James";
            TestItem.Address = "40 Glenfield Road";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Manager = false;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            int PrimaryKey = 1;
            TestStaff.ID = 1;
            TestStaff.Name = "James";
            TestStaff.Address = "40 Glenfield Road";
            TestStaff.DOB = DateTime.Now.Date;
            TestStaff.Manager = false;
            AllStaff.ThisStaff = TestStaff;
            PrimaryKey = AllStaff.Add();
            TestStaff.ID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            int PrimaryKey = 0;
            TestStaff.ID = 1;
            TestStaff.Name = "James";
            TestStaff.Address = "40 Glenfield Road";
            TestStaff.DOB = DateTime.Now.Date;
            TestStaff.Manager = false;
            AllStaff.ThisStaff = TestStaff;
            PrimaryKey = AllStaff.Add();
            TestStaff.ID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            int PrimaryKey = 0;
            TestStaff.ID = 1;
            TestStaff.Name = "James";
            TestStaff.Address = "40 Glenfield Road";
            TestStaff.DOB = DateTime.Now.Date;
            TestStaff.Manager = false;
            AllStaff.ThisStaff = TestStaff;
            PrimaryKey = AllStaff.Add();
            TestStaff.ID = PrimaryKey;
            TestStaff.ID = 2;
            TestStaff.Name = "Troy";
            TestStaff.Address = "24 Mill Lane";
            TestStaff.DOB = DateTime.Now.Date;
            TestStaff.Manager = true;
            AllStaff.ThisStaff = TestStaff;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByName("");
            Assert.AreEqual(AllStaff.Count,FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFoundOK()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByName("James Smith");
            if (FilteredStaff.Count == 1)
            {
                if (FilteredStaff.StaffList[0].ID != 1)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}