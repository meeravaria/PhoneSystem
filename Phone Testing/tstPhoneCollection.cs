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

        [TestMethod]
        public void AddMethodOK()
        //Add Method
        {
            //create an instance of the class we want to create 
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
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
            //set ThisPhone to the test data 
            AllPhones.ThisPhone = TestItem;
            //add the record 
            PrimaryKey = AllPhones.Add();
            //set the primary key of the test data 
            TestItem.PhoneID = PrimaryKey;
            //find the record 
            AllPhones.ThisPhone.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllPhones.ThisPhone, TestItem);
        }

        public void DeleteMethodOK()
        //Add Method
        {
            //create an instance of the class we want to create 
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
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
            //set ThisPhone to the test data 
            AllPhones.ThisPhone = TestItem;
            //add the record 
            PrimaryKey = AllPhones.Add();
            //set the primary key of the test data 
            TestItem.PhoneID = PrimaryKey;
            //find the record 
            AllPhones.ThisPhone.Find(PrimaryKey);
            //delete the record 
            AllPhones.Delete();
            //now find the record 
            Boolean Found = AllPhones.ThisPhone.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllPhones.ThisPhone, TestItem);
        }


        public void UpdateMethodOK()
        //Add Method
        {
            //create an instance of the class we want to create 
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create the item of test data
            clsPhone TestItem = new clsPhone();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
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
            //set ThisPhone to the test data 
            AllPhones.ThisPhone = TestItem;
            //add the record 
            PrimaryKey = AllPhones.Add();
            //set the primary key of the test data 
            TestItem.PhoneID = PrimaryKey;
            //modify the test data 
            TestItem.Active = false;
            TestItem.PhoneID = 1;
            TestItem.Capacity = 0;
            TestItem.Price = 0;
            TestItem.Colour = "0";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Description = "0.";
            TestItem.Make = "0";
            TestItem.Model = "0";
            TestItem.StockStatus = false;
            //set the record based on the new test data
            AllPhones.ThisPhone = TestItem;
            //update the method 
            AllPhones.Update();
            //find the record
            AllPhones.ThisPhone.Find(PrimaryKey);
            //test to see ThisPhone matches the test data
            Assert.AreEqual(AllPhones.ThisPhone, TestItem);
        }


        [TestMethod]
        public void ReportByMakeMethodOK()
        //Report By Make Method 
        {
            //create an instance of the class containing unfiltered results
            clsPhoneCollection AllPhones = new clsPhoneCollection();
            //create an instance of the filtered data
            clsPhoneCollection FilteredPhones = new clsPhoneCollection();
            //apply a blank string (Should return all phones) 
            FilteredPhones.ReportByMake("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllPhones.Count,FilteredPhones.Count);
        }


        [TestMethod]
        public void ReportByMakeNoneFound()
        //Report By Make None Found Method 
        {
            //create an instance of the filtered data
            clsPhoneCollection FilteredPhones = new clsPhoneCollection();
            //apply a blank string (Should return all phones) 
            FilteredPhones.ReportByMake(" xxxx");
            //test to see that the two values are the same 
            Assert.AreEqual(0, FilteredPhones.Count);
        }


        [TestMethod]
        public void ReportByMakeTestDataFound()
        //Report By Make Test Data Found Method 
        {
            //create an instance of the filtered data
            clsPhoneCollection FilteredPhones = new clsPhoneCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a make that does exist
            FilteredPhones.ReportByMake("9");
            //check that the correct number of records are found
            if (FilteredPhones.Count == 2)
            {
                //check that the first record id ID 36
                if (FilteredPhones.PhoneList[0].PhoneID != 259)
                {
                    OK = false;
                }

                //check that the first record is ID 37
                if (FilteredPhones.PhoneList[1].PhoneID != 260)
                {
                    OK = false;
                }

            }

            else
            {
                OK = false;
            }


            //test to see that the two values are the same 
            Assert.IsTrue(OK);
        }






      


    }
}
