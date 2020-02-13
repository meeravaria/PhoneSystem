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
            //create the items of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Active = true;
            TestItem.CountyNo = 1;
            TestItem.StaffID = 1;
            TestItem.DateOfBirth = "25/12/1996";
            TestItem.FirstName = "Meera";
            TestItem.LastName = "Varia";
            TestItem.Gender = true;
            TestItem.PostCode = "LE3 OGH";
            TestItem.Street = "Gosling Street";
            TestItem.Telephone = 0123456789;
            //add the item to the test list 
            mStaffList.Add(TestItem);
            //re initalise the object for some new data
            TestItem = new clsStaff();
            //set its properties 
            TestItem.Active = true;
            TestItem.CountyNo = 1;
            TestItem.StaffID = 1;
            TestItem.DateOfBirth = "21/01/1998";
            TestItem.FirstName = "Mati";
            TestItem.LastName = "Nitharsan";
            TestItem.Gender = true;
            TestItem.PostCode = "LE2 7FZ";
            TestItem.Street = "Lineker Road";
            TestItem.Telephone = 0987654321;
            //add the item to the test list
            mStaffList.Add(TestItem);

            
            }
            
        }

    }

   