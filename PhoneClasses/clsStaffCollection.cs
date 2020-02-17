using System;
using System.Collections.Generic;

namespace PhoneClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        //public property for the address list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        public clsStaff ThisStaff { get; set; }

        //constructor for the class
        public clsStaffCollection()
        {

            //******ERROR IS HERE WHICH IS CAUSING TEST FAILURE OF SOME OF THE PROPERTIES - WAS WORKING BEFORE I ADDED THIS CODE****

            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current records
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AStaff.County = Convert.ToString(DB.DataTable.Rows[Index]["County"]);
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.DateOfBirth = Convert.ToString(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.Gender = Convert.ToBoolean(DB.DataTable.Rows[Index]["Gender"]);
                AStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                AStaff.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AStaff.Telephone = Convert.ToInt32(DB.DataTable.Rows[Index]["Telephone"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;

            }

        }

    }
}


   