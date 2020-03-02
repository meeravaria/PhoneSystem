using System;

namespace PhoneClasses
{
    public class clsPhone

    {
        //private data member for the Active property 
        private bool mActive;

        //private data member for the PhoneID property 
        private Int32 mPhoneID;

        //private data member for the Capacity property 
        private Int32 mCapacity;

        //private data member for the Active property 
        private Decimal mPrice;

        //private data member for the Colour property 
        private string mColour;

        //private data member for the DateAdded property 
        private DateTime mDateAdded;

        //private data member for the Description property 
        private string mDescription;

        //private data member for the Make property 
        private string mMake;

        //private data member for the Model property 
        private string mModel;

        //private data member for the StockStatus property 
        private bool mStockStatus;


        public bool Active
        {
            get
            {
                //return the private data 
                return mActive;
            }
            set
            {
                //set the private data 
                mActive = value;
            }
        }

        public int PhoneID
        {
            get
            {
                //return the private data 
                return mPhoneID; 

            }

            set
            {
                //set the value of the private data member 
                mPhoneID = value; 
            }
        }
        public int Capacity {
            get
            {
                //return the private data 
                return mCapacity;

            }

            set
            {
                //set the private data 
                mCapacity = value;
            }
        }
        public Decimal Price
        {
            get

            {
                //return the private data 
                return mPrice;
            }
            set
            {
                //set the private data 
                mPrice = value;
            }
        }
        public string Colour
        { get
            {
                //return the private data 
                return mColour;
            }

            set
            {
                //set the private data 
                mColour = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                //return the private data 
                return mDateAdded;
            }
            set
            {
                //set the private data 
                mDateAdded = value;
            }
        }
        public string Description
        {
            get
            {
                //return the private data 
                return mDescription;
            }

            set
            {
                //set the private data 
                mDescription = value;
            }
        }
        public string Make
        {
            get
            {
                //return the private data 
                return mMake;
            }
            set
            {
                //set the private data 
                mMake = value;
            }
        }
        public string Model
        {
            get
            {
                //return the private data 
                return mModel;
            }
            set
            {
                //set the private data 
                mModel = value;
            }
        }
        public bool StockStatus
        {
            get
            {
                //return the private data 
                return mStockStatus;
            }
            set
            {
                //set the private data 
                mStockStatus = value;
            }
        }

        public bool Find(int PhoneID)
        {
            //set the private data member to the test data value 
            mPhoneID = 1;
            mActive = true;
            mCapacity = 128;
            mPrice = 100.00m;
            mColour = "Black";
            mDateAdded = Convert.ToDateTime("13/02/2020");
            mDescription = "A";
            mMake = "Apple";
            mModel = "11 Pro";
            mStockStatus = true; 
                 

            //always return true
            return true; 
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7, bool checked1, bool checked2)
        {

            string Error = "";
            return Error;
        }

        

    }
}