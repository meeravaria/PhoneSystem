using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;
using System.Collections.Generic; 

namespace Phone_Testing
{
    [TestClass]
    public class tstPhone
    {
        [TestMethod]
        public void InstanceOK()
        //Instance 
        {
            //create an instance of the class we want to create 
             clsPhone APhone = new clsPhone();
            //test to see that it exists 
            Assert.IsNotNull(APhone); 
        }

        [TestMethod]
        public void ActivePropertyOK()
        //Active Property
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
        //PhoneID Property 
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
        //Capacity Property 
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
        //Price Property 
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
        //Colour Property 
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
        //DateAdded Property 
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
        //Description Property 
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
        //Make Property 
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
        //Model Property 
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
        //Stock Status Property 
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
            Assert.AreEqual(AllPhones.Count, FilteredPhones.Count);
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
            //apply a make that doesn't exist
            FilteredPhones.ReportByMake("yyyy yy");
            //check that the correct number of records are found
            if (FilteredPhones.Count == 2)
            {
                //check that the first record id ID 36
                if (FilteredPhones.PhoneList[0].PhoneID != 36)
                {
                    OK = false;
                }

                //check that the first record is ID 37
                if (FilteredPhones.PhoneList[0].PhoneID != 37)
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
