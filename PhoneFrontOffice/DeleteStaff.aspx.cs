using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class DeleteStaff : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StaffID;

    //event handler for load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of staff to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    void DeleteStaff()
    {
        //function to delete the selected record
        //create a new instance of the staff
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to delete
        Staff.ThisStaff.Find(StaffID);
        //delete the record 
        Staff.Delete();
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete he record 
        DeleteStaff();
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }
}