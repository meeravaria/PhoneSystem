﻿using System;
using System.Collections.Generic;

namespace PhoneClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();


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

        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data 
                return mThisStaff;
            }
            set
            {
                //set the private data 
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the valies of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@County", mThisStaff.County);
            DB.AddParameter("@Street", mThisStaff.Street);
            DB.AddParameter("@Postcode", mThisStaff.PostCode);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@Telephone", mThisStaff.Telephone);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execte the query returning the primary key value 
            return DB.Execute("sproc_tblStaff_Insert");

        }


        public void Delete()
        {
            //delete the record pointed to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }


        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@County", mThisStaff.County);
            DB.AddParameter("@Street", mThisStaff.Street);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@Telephone", mThisStaff.Telephone);
            DB.AddParameter("@Active", mThisStaff.Active);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_Update");

        }
            
        //constructor for the class
        public clsStaffCollection()
        {
            
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //popualate the array list with the data table
            PopulateArray(DB);
         

            }
        }

        public void ReportByPostCode (string PostCode)
        {
            //filter the records based on a full or partial postcode
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode paramater to the database
            DB.AddParameter("@PostCode", PostCode);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByPostCode");
        //populate the array list with the data table 
        PopulateArray(DB);
        }

    }



   