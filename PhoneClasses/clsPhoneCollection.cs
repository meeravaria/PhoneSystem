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
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure 
            DB.Execute("sproc_tblPhone_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
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










    }
}
