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



        [TestMethod]
        public void ThisPhonePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create some test data to assign to the property 
            clsPhone TestPhone = new clsPhone();
            //set the properties of the test object 
            TestPhone.Active = true;
            TestPhone.PhoneID = 1;
            TestPhone.Capacity = 128;
            TestPhone.Price = 100;
            TestPhone.Colour = "red";
            TestPhone.DateAdded = DateTime.Now.Date;
            TestPhone.Description = "This is the latest phone.";
            TestPhone.Make = "Apple";
            TestPhone.Model = "C3500";
            TestPhone.StockStatus = true;
            //assign the data to the property 
            AllPhones.ThisPhone = TestPhone;
            //test to see that the two values are the same 
            Assert.AreEqual(AllPhones.ThisPhone, TestPhone);

        }

  



    }
}
