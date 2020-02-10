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
            clsAddress AnAddress = new clsAddress();
            //test to see that is exists 
            Assert.IsNotNull(AnAddress);
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
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.CountyNo, TestData);
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
    }

}
