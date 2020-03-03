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
            
            return "";
            }
        public string Valid(string County, string Street, string PostCode, string DateOfBirth, string FirstName, string LastName, bool Gender, int Telephone)
        {
            //create a string variable to store the error
            string Error = "";
            //if the county is blank
            if (County.Length == 3)
            {
                //record the error
                Error = Error + "The county must be more than 3 characters";
            }

            //if the county is greater than 16 characters
            if (County.Length > 15)
            {
                //record the error 
                Error = Error + "The county must be less than 15 characters : ";
            }

            //if the dateofbirth is blank
            if (DateOfBirth.Length == 4)
            {
                //record an error 
                Error = Error + "The date of birth must be more than 4 characters";
            }
            //if date of birth is greater than 10
            if (DateOfBirth.Length> 10)
            {
                //record the error 
                Error = Error + "The date of birth must be less than 10 characters";
            }
            // if the first name is blank
            if (FirstName.Length == 1)
            {
                //record the error
                Error = Error + "The first name must be more than 1 character ";
            }
            //if the first name is greater than 25 characters 
            if (FirstName.Length >25)
            {
                //record the error
                Error = Error + "The first name must be less than 25 characters";

            }
            //if last name is blank 
            if (LastName.Length == 1)
            {
                Error = Error + "The last name must be more than 1 character";
            }
            //if the last name is greater than 25 characters
            if (LastName.Length >25)
            {
                //record the error
                Error = Error + "The last name must be less than 25 characters";
            }
            //if the postcode is blank 
            if (PostCode.Length ==1)
            {
                //record the error
                Error = Error + "The postcode must be more than 1 character";           
            }
            //if the postcode is greater than 7 characters
            if (PostCode.Length >7)
            {
                //record the error
                Error = Error + "The postcode must less than 7 characters";
            }
            // if street is blank
            if (Street.Length == 3)
            {
                //record the error
                Error = Error + "The street must be more than 3 characters";
            }
            //if the street is greater than 50 characters
            if (Street.Length >50)
            {
                //record the error
                Error = Error + "The street must be less than 50 characters";
            }
            ////if telephone is blank 
            //if (Telephone == 0)
            //{
            //    //record the error 
            //    Error = Error + "The telephone must not be left blank";
            //}
            ////if telephone is greater than 10 characters
            //if (Telephone > 10)
            //{
            //    Error = Error + "The telephone must be less than 10 characters";
            //}
            //return an error messages
           return Error;
        }
        
    }


}