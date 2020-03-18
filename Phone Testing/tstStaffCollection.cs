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
            TestItem.StaffID = 847;
            TestItem.DateOfBirth = "25/12/1996";
            TestItem.FirstName = "Meera";
            TestItem.LastName = "Varia";
            TestItem.Gender = "Female";
            TestItem.PostCode = "LE3 0BH";
            TestItem.Street = "Western Road";
            TestItem.Telephone = 1234567891;
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
            TestStaff.StaffID = 847;
            TestStaff.DateOfBirth = "25/12/1996";
            TestStaff.FirstName = "Meera";
            TestStaff.LastName = "Varia";
            TestStaff.Gender = "Female";
            TestStaff.PostCode = "LE3 0BH";
            TestStaff.Street = "Western Road";
            TestStaff.Telephone = 1234567891;
            //assign the data to the property 
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.Active = true;
            TestItem.StaffID = 847;
            TestItem.County = "Buckinghamshire";
            TestItem.Street = "Western Road";
            TestItem.PostCode = "LE3 0BH";
            TestItem.DateOfBirth = "25/12/1996";
            TestItem.FirstName = "Meera";
            TestItem.LastName = "Varia";
            TestItem.Gender = "Female";
            TestItem.Telephone = 1234567891;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.Active = true;
            TestItem.StaffID = 847;
            TestItem.County = "Buckinghamshire";
            TestItem.Street = "Western Road";
            TestItem.PostCode = "LE3 0BH";
            TestItem.DateOfBirth = "25/12/1996";
            TestItem.FirstName = "Meera";
            TestItem.LastName = "Varia";
            TestItem.Gender = "Female";
            TestItem.Telephone = 1234567891;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record 
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the records was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.Active = true;
            TestItem.StaffID = 847;
            TestItem.County = "Buckinghamshire";
            TestItem.Street = "Western Road";
            TestItem.PostCode = "LE3 0BH";
            TestItem.DateOfBirth = "25/12/1996";
            TestItem.FirstName = "Meera";
            TestItem.LastName = "Varia";
            TestItem.Gender = "Female";
            TestItem.Telephone = 1234567891;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //modify the test data 
            TestItem.Active = true;
            TestItem.StaffID = 850;
            TestItem.County = "Manchester";
            TestItem.Street = "Ellen Street";
            TestItem.PostCode = "HP3 5LS";
            TestItem.DateOfBirth = "06/05/1979";
            TestItem.FirstName = "Jane";
            TestItem.LastName = "Doe";
            TestItem.Gender = "Female";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update record 
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //now find the record
            //test to see that the records was not found
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an insrance of the filtered data 
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByPostCode("");
            //test to see the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);


        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {

            //create an insrance of the filtered data 
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByPostCode("xxx xxx");
            //test to see the two values are the same
            Assert.AreEqual(0, FilteredStaff.Count);

        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {

            //create an insrance of the filtered data 
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that does exists
            FilteredStaff.ReportByPostCode("LE3 0BH");
            //check that the correct numbeR of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 847
                if (FilteredStaff.StaffList[0].StaffID != 847)
                {
                    OK = false;
                }

                //check the first record is ID 852
                if (FilteredStaff.StaffList[1].StaffID != 849)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see that there are no records
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 847;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }



    }

}




