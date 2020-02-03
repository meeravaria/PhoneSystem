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
        public void CapacityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property 
             Int32 TestData = 1;
            //assign the data to the property
            AnAddress.Capacity = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Capacity, TestData);
        }




    }
}
