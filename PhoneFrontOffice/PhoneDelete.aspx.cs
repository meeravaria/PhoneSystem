using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses; 

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 PhoneID; 

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of phone to be deleted from the session object 
        PhoneID = Convert.ToInt32(Session["PhoneID"]); 

    }

    void DeletePhone()
    {
        //function to delete the selected record 

        //create a new instance of the phone book 
        clsPhoneCollection PhoneBook = new clsPhoneCollection();
        //find the record to delete
        PhoneBook.ThisPhone.Find(PhoneID);
        //delete the record 
        PhoneBook.Delete();
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record 
        DeletePhone();
        //redirect back to the main page 
        Response.Redirect("Default.aspx"); 
      
    }

    protected void btnNO_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}