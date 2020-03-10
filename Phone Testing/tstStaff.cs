using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace Phone_Testing
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some data to pass to the method
        string County = "Buckinghamshire";
        string Street = "Gosling Street";
        string PostCode = "LE3 0GH";
        string DateOfBirth = "25/12/1996";
        string FirstName = "Meera";
        string LastName = "Varia";
        string Gender = "true";
        string Telephone = "12345678910";


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
        public void StaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.StaffID != 55)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.Active != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffStreetFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.Street != "Gosling Street")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffCountyFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.County != "Buckinghamshire")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffPostCodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.PostCode != "LE3 0GH")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.DateOfBirth != "25/12/1996")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.FirstName != "Meera")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.LastName != "Varia")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffGenderFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.Gender != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffTelephoneFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 StaffID = 55;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff no
            if (AStaff.Telephone != 145678932)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string County = "buc" ; //this should trigger an error - 3 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountyMin()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string County = "buck"; //this should be ok - 4 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string County = "bucks"; //this should be ok - 5 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMaxLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string County = "buckinghamshir"; //this should be ok - 14 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string County = "buckinghamshire"; //this should be ok - 15 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        

        [TestMethod]
        public void CountyMid()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string County = "bucking"; //this should be ok - 7 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
            public void CountyMaxPlusOne()
            {

              //create an instance of the class we want to create
              clsStaff AStaff = new clsStaff();
              //string variable to store any error message
              String Error = "";
              //create some test data to pass to the method
              string County = "buckinghamshiree"; //this shouldn't be ok - 16 characters
              //invoke the method
              Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
              //test to see that the results is correct 
              Assert.AreNotEqual(Error, "");
            }

        [TestMethod]
        public void CountyExtremeMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string County = ""; //this shouldn't be ok - 16 characters
            County = County.PadRight(50, 'b'); //this should fail
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateOfBirth = "25/1"; //this shouldn't be ok - 4 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateOfBirth = "25/12"; //this should be ok - 5 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateOfBirth = "25/12/"; //this should be ok - 6 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateOfBirth = "25/12/199"; //this shouldn't be ok - 9 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void DateOfBirthMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateOfBirth = "25/12/1996"; //this should be ok - 10 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateOfBirth = "25/12/19966"; //this should be ok - 11 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMid()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateOfBirth = "25/12/1996"; //this should be ok - 5 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateOfBirth = ""; //this shouldn't be ok - 16 characters
            DateOfBirth = DateOfBirth.PadRight(20, '2'); //this should fail
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "M"; //this should trigger an error - 1 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Me"; //this should be ok - 2 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Mee"; //this should be ok - 3 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Meeraaaaaaaaaaaaaaaaaaaa"; //this should be ok - 24 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Meeraaaaaaaaaaaaaaaaaaaaa"; //this should be ok - 25 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Meeraaaaaaaaaaaaaaaaaaaaaa"; //this should be ok - 26 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Meeraaaaaaaa"; //this should be ok - 12 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this shouldn't be ok - 50 characters
            FirstName = FirstName.PadRight(50, 'm'); //this should fail
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "V"; //this should trigger an error - 1 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Va"; //this should be ok - 2 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Var"; //this should be ok - 3 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Variaaaaaaaaaaaaaaaaaaaa"; //this should be ok - 24 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Variaaaaaaaaaaaaaaaaaaaaa"; //this should be ok - 25 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Variaaaaaaaaaaaaaaaaaaaaaa"; //this shouldn't be ok - 26 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Variaaaaaaaa"; //this should be ok - 12 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; //this shouldn't be ok - 50 characters
            LastName = LastName.PadRight(50, 'v'); //this should fail
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "L"; //this should trigger an error - 1 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE"; //this should be ok - 2 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE3"; //this shouldn't be ok - 3 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE3 0GH"; //this should be ok - 6 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "SW179DE"; //this should be ok - 7 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE30GHED"; //this shouldn't be ok - 8 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE3"; //this shouldn't be ok - 3 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = ""; //this shouldn't be ok - 50 characters
            PostCode = PostCode.PadRight(10, 'h'); //this should fail
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "Lov"; //this should trigger an error - 3 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMin()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "Gosl"; //this should be ok - 4 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "Gosli"; //this should be ok - 5 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "Goslingggggggggggggggggggggggggggggggggggg street"; //this should be ok - 49 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "Goslinggggggggggggggggggggggggggggggggggggg Street"; //this should be ok - 50 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "Goslingggggggggggggggggggggggggggggggggggggg Street"; //this shouldn't be ok - 51 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMid()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "Goslingggggggggggg Street"; //this shouldn't be ok - 25 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetExtremeMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = ""; //this shouldn't be ok - 50 characters
            Street = Street.PadRight(100, 'g'); //this should fail
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderMin()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "false"; 
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Gender = "true";
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TelephoneMinLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "1"; //this should trigger an error - 1 number
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TelephoneMin()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "11"; //this shouldn't trigger an error - 11 number
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMinPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "12"; //this should trigger an error - 12 numbers
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxLessOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "10"; //this should trigger an error - 10 number
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "11"; //this should trigger an error - 11 numbers
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMaxPlusOne()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "12"; //this should trigger an error - 12 numbers
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneMid()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "6"; //this should trigger an error - 6 numbers
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneExtremeMax()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Telephone = "22"; //this should trigger an error - 22 characters
            //invoke the method
            Error = AStaff.Valid(County, Street, PostCode, DateOfBirth, FirstName, LastName, Gender, Telephone);
            //test to see that the results is correct 
            Assert.AreNotEqual(Error, "");
        }

    }
}
