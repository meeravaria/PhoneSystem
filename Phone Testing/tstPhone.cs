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
        public void FindMethodOK()
        //Find Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method 
            Found = APhone.Find(PhoneID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);

        }


        [TestMethod]
        public void PhoneNoFound()
        //Phone No Found Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.PhoneID != 1)
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PhoneActiveFound()
        //Phone Active Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.Active != true)
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void PhoneDateAddedFound()
        //Phone Active Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.DateAdded != Convert.ToDateTime("13/02/2020"))
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void PhoneCapacityFound()
        //Phone No Found Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.Capacity != 128)
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PhonePriceFound()
        //Phone No Found Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.Price != Convert.ToDecimal(100.00))
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PhoneColourFound()
        //Phone No Found Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.Colour != "Black")
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PhoneDescriptionFound()
        //Phone No Found Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.Description != "A")
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void PhoneMakeFound()
        //Phone No Found Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.Make != "Apple")
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }



        [TestMethod]
        public void PhoneModelFound()
        //Phone No Found Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.Model != "11 Pro")
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void PhoneStockStatusFound()
        //Phone No Found Method
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PhoneID = 1;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.StockStatus != true)
            {
                OK = false;
            }

            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }
    }
}
