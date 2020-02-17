using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;
using System.Collections.Generic;

namespace Phone_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }


        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllStaff.Count = SomeCount;
        //    //test to see that it exists
        //    Assert.AreEqual(AllStaff.Count, SomeCount);
        //}


        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.County = "Buckinghamshire";
            TestItem.StaffID = 1;
            TestItem.DateOfBirth = "25/12/1996";
            TestItem.FirstName = "Meera";
            TestItem.LastName = "Varia";
            TestItem.Gender = true;
            TestItem.PostCode = "LE3 OGH";
            TestItem.Street = "Gosling Street";
            TestItem.Telephone = 0123456789;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object 
            TestStaff.Active = true;
            TestStaff.County = "Buckinghamshire";
            TestStaff.StaffID = 1;
            TestStaff.DateOfBirth = "25/12/1996";
            TestStaff.FirstName = "Meera";
            TestStaff.LastName = "Varia";
            TestStaff.Gender = true;
            TestStaff.PostCode = "LE3 OGH";
            TestStaff.Street = "Gosling Street";
            TestStaff.Telephone = 0123456789;
            //assign the data to the property 
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    //create an instance of the class we want to create
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //create some test data to assign to the property
        //    //in this case the data needs to be a list of objects
        //    List<clsStaff> TestList = new List<clsStaff>();
        //    //add an item to the list
        //    //create the item of the test data
        //    clsStaff TestItem = new clsStaff();
        //    //set its properties
        //    TestItem.Active = true;
        //    TestItem.County = "Buckinghamshire";
        //    TestItem.StaffID = 1;
        //    TestItem.DateOfBirth = "25/12/1996";
        //    TestItem.FirstName = "Meera";
        //    TestItem.LastName = "Varia";
        //    TestItem.Gender = true;
        //    TestItem.PostCode = "LE3 OGH";
        //    TestItem.Street = "Gosling Street";
        //    TestItem.Telephone = 0123456789;
        //    //add the item to the test list 
        //    TestList.Add(TestItem);
        //    //assign the data to the property
        //    AllStaff.StaffList = TestList;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStaff.Count, TestList.Count);

        //}

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllStaff.Count, 2);
        //}
        
        }

    }


