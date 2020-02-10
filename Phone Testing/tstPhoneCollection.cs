using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;
using System.Collections.Generic;

namespace Phone_Testing
{
    [TestClass]
    public class tstPhoneCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllPhones); 
        } 
        

        [TestMethod]
        public void PhoneListOK()
        //Stock Status Property 
        {
            //create an instance of the class we want to create 
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsPhone> TestList = new List<clsPhone>();
            //add an item to the list 
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //set its properties 
            TestItem.Active = true;
            TestItem.PhoneID = 1;
            TestItem.Capacity = 128;
            TestItem.Price = 100;
            TestItem.Colour = "red";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Description = "This is the latest phone.";
            TestItem.Make = "Apple";
            TestItem.Model = "C3500";
            TestItem.StockStatus = true;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllPhones.PhoneList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPhones.PhoneList, TestList);


        }
    }
}
