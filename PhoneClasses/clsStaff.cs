using System;

namespace PhoneClasses
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public string County { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Telephone { get; set; }
        public int StaffID { get; set; }

        public bool Find(int StaffID)
        {
            return false;
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            string Error = "";
            return Error;
        }
    }


}