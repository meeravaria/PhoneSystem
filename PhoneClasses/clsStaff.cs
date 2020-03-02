using System;


namespace PhoneClasses
{
    public class clsStaff
    {
        private bool mActive;

        private string mCounty;

        private string mStreet;

        private string mPostCode;

        private string mDateOfBirth;

        private string mFirstName;

        private string mLastName;

        private bool mGender;

        private int mTelephone;

        private int mStaffID;

     
        public int StaffID 
        {
            get
            {
                //return the private data 
                return mStaffID;
            }
            set
            {
                //set the private data 
                mStaffID = value;
            }
        }

        public string County
        {
            get
            {
                //return the private data 
                return mCounty;
            }
            set
            {
                //set the private data 
                mCounty = value;
            }
        }

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

        public string Street
        {
            get
            {
                //return the private data 
                return mStreet;
            }
            set
            {
                //set the private data 
                mStreet = value;
            }
        }

        public string PostCode
        {
            get
            {
                //return the private data 
                return mPostCode;
            }
            set
            {
                //set the private data 
                mPostCode = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                //return the private data 
                return mDateOfBirth;
            }
            set
            {
                //set the private data 
                mDateOfBirth = value;
            }
        }

        public string FirstName
        {
            get
            {
                //return the private data 
                return mFirstName;
            }
            set
            {
                //set the private data 
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                //return the private data 
                return mLastName;
            }
            set
            {
                //set the private data 
                mLastName = value;
            }
        }

        public bool Gender
        {
            get
            {
                //return the private data 
                return mGender;
            }
            set
            {
                //set the private data 
                mGender = value;
            }
        }


        public int Telephone
        {
            get
            {
                //return the private data 
                return mTelephone;
            }
            set
            {
                //set the private data 
                mTelephone = value;
            }
        }

        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StaffID to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored parameter
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mCounty = Convert.ToString(DB.DataTable.Rows[0]["County"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mDateOfBirth = Convert.ToString(DB.DataTable.Rows[0]["DateOfBirth"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                mTelephone = Convert.ToInt32(DB.DataTable.Rows[0]["Telephone"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }


        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            string Error = "";
            return Error;
        }
    }


}