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
            clsAddress AnAddress = new clsAddress();
            //test to see that it exists 
            Assert.IsNotNull(AnAddress); 
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            AnAddress.Active = TestData; 
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Active, TestData);
        }

        [TestMethod]
        public void PhoneIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.PhoneID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.PhoneID, TestData);
        }

        [TestMethod]
        public void CapacityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
             Int32 TestData = 128;
            //assign the data to the property
            AnAddress.Capacity = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Capacity, TestData);
        }


        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            Int32 TestData = 100;
            //assign the data to the property
            AnAddress.Price = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Price, TestData);
        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            String TestData = "red";
            //assign the data to the property
            AnAddress.Colour = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Colour, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date; 
            //assign the data to the property
            AnAddress.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.DateAdded, TestData);
        }


        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            String TestData = "This is the latest phone.";
            //assign the data to the property
            AnAddress.Description = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Description, TestData);
        }


        [TestMethod]
        public void MakePropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            String TestData = "Apple";
            //assign the data to the property
            AnAddress.Make = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Make, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            String TestData = "C3500";
            //assign the data to the property
            AnAddress.Model = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Model, TestData);
        }

        [TestMethod]
        public void StockStatusPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            AnAddress.StockStatus = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.StockStatus, TestData);
        }

    }
}
