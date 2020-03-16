using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;
using System.Collections.Generic; 

namespace Phone_Testing
{
    [TestClass]
    public class tstPhone
    {
        //good test data
        //create some test data to pass to the method 


        string Capacity = "16";
        string Price = "100.00";
        string Colour = "Blue";
        string DateAdded = DateTime.Now.Date.ToString();
        string Description = "Old Phone";
        string Make = "Nokia";
        string Model = "550";

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
            Int32 PhoneID = 3;
            //invoke the method 
            Found = APhone.Find(PhoneID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        /// <summary>
        ///  COLOUR 
        /// </summary>

        [TestMethod]
        public void ColourMinLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Colour = ""; //this should fail
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ColourMin()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Colour = "a"; //this should  be ok
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ColourMinPlusOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Colour = "aa"; //this should  be ok
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ColourMaxLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Colour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should  be ok
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ColourMax()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Colour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should  be ok
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ColourMaxPlusOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Colour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ColourExtremeMax()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Colour = ""; //this should fail
            Colour = Colour.PadRight(100, 'a');
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ColourMid()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Colour = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should  be ok
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        /// <summary>
        /// DATEADDED
        /// </summary>

        [TestMethod]
        public void DateAddedExtremeMim()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime TestDate;
            //set the data to todays date 
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non data value 
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// DESCRIPTION
        /// </summary>

        [TestMethod]
        public void DescriptionMinLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Description = ""; //this should fail
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Description = "a";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Description = "aa";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Description = ""; //this should pass
            Description = Description.PadLeft(499, 'a');
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Description = "";
            Description = Description.PadRight(500, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Description = "";
            Description = Description.PadRight(501, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium.";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Description = ""; //this should fail
            Description = Description.PadRight(1000, 'a');
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }


        /// <summary>
        /// MAKE
        /// </summary>

        [TestMethod]
        public void MakeMinLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Make = ""; //this should fail
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void MakeMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            // this should pass
            string Make = "a";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void MakeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            // string variable to store any error message
            String Error = "";
            //this should pass
            string Make = "aa";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MakeMaxLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Make = ""; //this should pass
            Make = Make.PadLeft(49, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MakeMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Make = "";
            Make = Make.PadRight(50, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MakeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Make = "";
            Make = Make.PadRight(51, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            // this should pass
            string Make = "Lorem ipsum dolor sit ame";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeExtremeMax()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Make = ""; //this should fail
            Make = Make.PadRight(1000, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        /// <summary>
        /// MODEL
        /// </summary>

        [TestMethod]
        public void ModelMinLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Model = ""; //this should fail
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ModelMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            // this should pass
            string Model = "aaa";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void ModelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            // string variable to store any error message
            String Error = "";
            //this should pass
            string Model = "aaaa";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ModelMaxLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Model = ""; //this should pass
            Model = Model.PadLeft(9, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ModelMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Model = "";
            Model = Model.PadRight(10, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ModelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Model = "";
            Model = Model.PadRight(11, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            // this should pass
            string Model = "Lore";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelExtremeMax()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Model = ""; //this should fail
            Model = Model.PadRight(50, 'a');
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        /// <summary>
        /// PRICE   
        /// </summary>


        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "999.99";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "0.00";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            // this should pass
            string Price = "500.00";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "500000.00";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceExtremeMin()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "-100";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Price = "-0.01"; //this should fail
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxPlusOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Price = "1000.00"; //this should fail
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinPlusOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string  Price = "0.01"; //this should fail
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string  Price = "999.98"; //this should fail
            //invoke the method 
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }


        /// <summary>
        /// CAPACITY
        /// </summary>

        [TestMethod]
        public void CapacityMin()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "1";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CapacityMax()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "100";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CapacityMinPlusOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "10";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CapacityMaxLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "10";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CapacityMid()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "10";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }




        [TestMethod]
        public void CapacityMinLessOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "0";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CapacityMaxPlusOne()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "1000";
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CapacityExtremeMax()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "1000000000"; //this should fail
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CapacityExtremeMin()

        {
            //create an instance of the filtered data
            clsPhone APhone = new clsPhone();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "-1000000000"; //this should fail
            //invoke the method
            Error = APhone.Valid(Capacity, Price, Colour, DateAdded, Description, Make, Model);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

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
            Int32 PhoneID = 3;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.PhoneID != 3)
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
            Int32 PhoneID = 3;
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
            Int32 PhoneID = 3;
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
            Int32 PhoneID = 3;
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
            Int32 PhoneID = 3;
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
            Int32 PhoneID = 3;
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
            Int32 PhoneID = 3;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.Description != "This is the latest phone.")
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
            Int32 PhoneID = 3;
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
            Int32 PhoneID = 3;
            //invoke the method
            Found = APhone.Find(PhoneID);
            //check the PhoneID
            if (APhone.Model != "11")
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
            Int32 PhoneID = 3;
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
