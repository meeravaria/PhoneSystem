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

    



        public string Valid(string Capacity, string Price, string Colour, string DateAdded, string Description, string Make, string Model)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;


            ///Capacity Validation 
            try
            {
                Int32 TempCapacity = Convert.ToInt32(Capacity);
                //if Capacity is blank
                if (TempCapacity == 0)
                {
                    //record the error
                    Error = Error + " The capacity may not be blank." + " ";
                }

                if (TempCapacity < 0 | TempCapacity > 999)
                {
                    //set the error message 
                    Error = Error + "The capacity must between 1 to 3 characters" + " ";
                }

            }
            catch
            {
                //record the error 
                Error = Error + "The data was not a valid capacity : ";
            }

            ///Price Validation 
            try
            {

                decimal PriceTemp = Convert.ToDecimal(Price);
                if (PriceTemp < 0.01m | PriceTemp > 999.99m)
                {
                    //set the error message 
                    Error = Error + "The price must between £0.01 to £999.99." + " ";
                }

            }

            catch
            {
                //record the error 
                Error = Error + "The data was not a valid price : ";
            }

            ///Colour Validation
            //if Colour is blank
            if (Colour.Length == 0)
            {
                //record the error
                Error = Error + " The colour may not be blank." + " ";
            }

           if (Colour.Length < 1 | Colour.Length > 50)
           {
                //set the error message 
                Error = Error + "Colour must between 1 to 50 characters." + " ";
           }

           ///Date Validation
            try
            {
                 //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                if(DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the past. Please enter today's date! " + "  "; 
                }

               
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future. Please enter today's date! " + "  ";
                }

            }

           catch
            {
                //record the error 
                Error = Error + "The data was not a valid date : "; 
            }


            ///Desciription Validation
            //if Description is blank
            if (Description.Length == 0)
            {
                //record the error
                Error = Error + " The description may not be blank." + " ";
            }

            if (Description.Length < 1 | Description.Length > 500)
            {
                //set the error message 
                Error = Error + "The description must between 1 to 500 characters." + " ";
            }

            ///Make Validation
            //if Make is blank
            if (Make.Length == 0)
            {
                //record the error
                Error = Error + " The make may not be blank." + " ";
            }

            if (Make.Length < 1 | Make.Length > 50)
            {
                //set the error message 
                Error = Error + "The make must between 1 to 50 characters." + " ";
            }

            //if Make is blank
            if (Model.Length == 0)
            {
                //record the error
                Error = Error + " The model may not be blank." + " ";
            }


            ///Model Validation
            if (Model.Length < 1 | Model.Length > 10)
            {
                //set the error message 
                Error = Error + "The model must between 1 to 50 characters." + " ";
            }
            
            //return any error messages
            return Error;
        }

        
    }
}