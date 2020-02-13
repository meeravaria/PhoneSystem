using System;
using System.Collections.Generic;

namespace PhoneClasses
{
    public class clsPhoneCollection
    {
        //private data member for the list 
        List<clsPhone> mPhoneList = new List<clsPhone>();

        //public property for the address list 
        public List<clsPhone> PhoneList
        {
            get
            {
                //return the private data 
                return mPhoneList;
            }
            set
            {
                //set the private data 
                mPhoneList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list 
                return mPhoneList.Count;
            }
            set
            {
                //we shall worry about this later
               
            }
        }

    

        public clsPhone ThisPhone { get; set; }


        public clsPhoneCollection()
        {
            //create the items of test data
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
            mPhoneList.Add(TestItem);
            //re initialise the object for some new data 
            TestItem = new clsPhone();
            //set its properties 
            TestItem.Active = true;
            TestItem.PhoneID = 2;
            TestItem.Capacity = 64;
            TestItem.Price = 30;
            TestItem.Colour = "blue";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Description = "This is an old phone.";
            TestItem.Make = "Samsung";
            TestItem.Model = "S11";
            TestItem.StockStatus = true;
            //add the item to the list 
            mPhoneList.Add(TestItem); 
        }









    }
}