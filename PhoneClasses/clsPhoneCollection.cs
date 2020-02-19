using System;
using System.Collections.Generic;

namespace PhoneClasses
{
    public class clsPhoneCollection
    {
       
        //private data member for the list 
        List<clsPhone> mPhoneList = new List<clsPhone>();
        //private data member thisPhone 
        clsPhone mThisPhone = new clsPhone(); 

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



        public clsPhone ThisPhone
        {
            get
            {
                //return the private data 
                return mThisPhone;
            }

            set
            {
                //set the private data 
                mThisPhone = value;
            }
        }

        public int Add()
        {
            //adds a mew record to the database based on the values of mThisPhone 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Capacity", mThisPhone.Capacity);
            DB.AddParameter("@Price", mThisPhone.Price);
            DB.AddParameter("@Colour", mThisPhone.Colour);
            DB.AddParameter("@DateAdded", mThisPhone.DateAdded);
            DB.AddParameter("@Description", mThisPhone.Description);
            DB.AddParameter("@Make", mThisPhone.Make);
            DB.AddParameter("@Model", mThisPhone.Model);
            DB.AddParameter("@StockStatus", mThisPhone.StockStatus);
            DB.AddParameter("@Active", mThisPhone.Active);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblPhone_Insert");
        }


        public void Delete ()
        {
            //deletes the record pointed to by thisPhone
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@PhoneID", mThisPhone.PhoneID);
            //execute the stored procedure 
            DB.Execute("sproc_tblPhone_Delete"); 
        }

        public void Update()
        {
            //update an existing record based on the values of thisPhone
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@PhoneID", mThisPhone.PhoneID);
            DB.AddParameter("@Capacity", mThisPhone.Capacity);
            DB.AddParameter("@Price", mThisPhone.Price);
            DB.AddParameter("@Colour", mThisPhone.Colour);
            DB.AddParameter("@DateAdded", mThisPhone.DateAdded);
            DB.AddParameter("@Description", mThisPhone.Description);
            DB.AddParameter("@Make", mThisPhone.Make);
            DB.AddParameter("@Model", mThisPhone.Model);
            DB.AddParameter("@StockStatus", mThisPhone.StockStatus);
            DB.AddParameter("@Active", mThisPhone.Active);
            //execute the stored procedure 
            DB.Execute("sproc_tblPhone_Update");
        }

        public clsPhoneCollection()
        {
          
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure 
            DB.Execute("sproc_tblPhone_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB); 
            

        }





        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list 
            mPhoneList = new List<clsPhone>(); 
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address 
                clsPhone APhone = new clsPhone();
                //read in the fields from the current record
                APhone.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                APhone.PhoneID = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneID"]);
                APhone.Capacity = Convert.ToInt32(DB.DataTable.Rows[Index]["Capacity"]);
                APhone.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                APhone.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                APhone.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                APhone.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                APhone.Make = Convert.ToString(DB.DataTable.Rows[Index]["Make"]);
                APhone.Model = Convert.ToString(DB.DataTable.Rows[Index]["Model"]);
                APhone.StockStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["StockStatus"]);
                //add the record to the private data member 
                mPhoneList.Add(APhone);
                //point at the next record
                Index++;
            }

        }

        public void ReportByMake(string Make)
        {
            //filters the records based on full or partial make
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the Make parameter to the database 
            DB.AddParameter("@Make", Make);
            //execute the stored procedure 
            DB.Execute("sproc_tblPhone_FilterByMake");
            //populate the array list with the data table 
            PopulateArray(DB); 
        }
    }
}
