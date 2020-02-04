using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace Phone_Testing
{
    [TestClass]
    public class tstPhone
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //test to see that it exists 
            Assert.IsNotNull(APhone); 
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            APhone.Active = TestData; 
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.Active, TestData);
        }

        [TestMethod]
        public void PhoneIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property
            APhone.PhoneID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.PhoneID, TestData);
        }

        [TestMethod]
        public void CapacityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            Int32 TestData = 128;
            //assign the data to the property
            APhone.Capacity = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.Capacity, TestData);
        }


        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            Int32 TestData = 100;
            //assign the data to the property
            APhone.Price = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.Price, TestData);
        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            String TestData = "red";
            //assign the data to the property
            APhone.Colour = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.Colour, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            APhone.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.DateAdded, TestData);
        }


        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            String TestData = "This is the latest phone.";
            //assign the data to the property
            APhone.Description = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.Description, TestData);
        }

        [TestMethod]
        public void MakePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            String TestData = "Apple";
            //assign the data to the property
            APhone.Make = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.Make, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            String TestData = "C3500";
            //assign the data to the property
            APhone.Model = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.Model, TestData);
        }

        [TestMethod]
        public void StockStatusPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhone APhone = new clsPhone();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            APhone.StockStatus = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APhone.StockStatus, TestData);
        }




     
    









    }





}
