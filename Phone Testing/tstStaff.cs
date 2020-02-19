using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace Phone_Testing
{
    [TestClass]
    public class tstStaff
    {


        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that is exists 
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AStaff.Active = TestData;
            //test to see that is exists 
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void CountyPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Buckingahmshire";
            //assign the data to the property
            AStaff.County = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.County, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Gosling Street";
            //assign the data to the property
            AStaff.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Street, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AStaff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PostCode, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "25/12/1996";
            //assign the data to the property
            AStaff.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateOfBirth, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Meera";
            //assign the data to the property
            AStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Varia";
            //assign the data to the property
            AStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AStaff.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Gender, TestData);
        }

        [TestMethod]
        public void TelephonePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 0123456789;
            //assign the data to the property
            AStaff.Telephone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Telephone, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 01;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
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
            TestItem.StaffID = 1;
            TestItem.County = "Leicestershire";
            TestItem.Street = "Hamilton Road";
            TestItem.PostCode = "LE5 5TH";
            TestItem.DateOfBirth = "13/08/1991";
            TestItem.FirstName = "Maya";
            TestItem.LastName = "Smith";
            TestItem.Gender = true;
            TestItem.Telephone = 0123456789;
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
            TestItem.StaffID = 1;
            TestItem.County = "Leicestershire";
            TestItem.Street = "Hamilton Road";
            TestItem.PostCode = "LE5 5TH";
            TestItem.DateOfBirth = "13/08/1991";
            TestItem.FirstName = "Maya";
            TestItem.LastName = "Smith";
            TestItem.Gender = true;
            TestItem.Telephone = 0123456789;
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
            TestItem.StaffID = 1;
            TestItem.County = "Leicestershire";
            TestItem.Street = "Hamilton Road";
            TestItem.PostCode = "LE5 5TH";
            TestItem.DateOfBirth = "13/08/1991";
            TestItem.FirstName = "Maya";
            TestItem.LastName = "Smith";
            TestItem.Gender = true;
            TestItem.Telephone = 0123456789;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.StaffID = PrimaryKey;
            //modify the test data 
            TestItem.Active = true;
            TestItem.StaffID = 2;
            TestItem.County = "London";
            TestItem.Street = "Love Street";
            TestItem.PostCode = "HP18 RSC";
            TestItem.DateOfBirth = "15/04/1992";
            TestItem.FirstName = "Sarah";
            TestItem.LastName = "Smith";
            TestItem.Gender = true;
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
            //apply a post code that doesn't exists
            FilteredStaff.ReportByPostCode("yyy yyy");
            //check that the correct numbe of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 5
                if (FilteredStaff.StaffList[0].StaffID ! = 5)
                {
                    OK = false;
                }

                //check the first record is ID 37
                if (FilteredStaff.StaffList[1].StaffID !=6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false
            }

            //test to see that there are no records
            Assert.IsTrue(OK);
         

        }



    }
}
