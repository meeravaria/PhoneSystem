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
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the phone id to search for
            DB.AddParameter("@PhoneID", PhoneID);
            //execute the stored procedure
            DB.Execute("sproc_tblPhone_FilterByPhoneID"); 
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mPhoneID = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneID"]);
                mCapacity = Convert.ToInt32(DB.DataTable.Rows[0]["Capacity"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mMake = Convert.ToString(DB.DataTable.Rows[0]["Make"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                mStockStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["StockStatus"]);
                //return that everything worked OK 
                return true; 

            }
            else
            {
                //return false indicating a problem 
                return false; 
            }
                 
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7, bool checked1, bool checked2)
        {

            string Error = "";
            return Error;
        }

        

    }
}