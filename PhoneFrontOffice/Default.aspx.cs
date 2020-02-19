using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Int32 PhoneID; 

    //this function handles the load event for the page

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of phone to be processed
        PhoneID = Convert.ToInt32(Session["PhoneID"]); 
        if (IsPostBack == false)
        {
            //populate the list of phones
            DisplayPhones(); 
        }

       
    }

    void DisplayPhones()
    {
        //create an instance of the Phone Collection
        PhoneClasses.clsPhoneCollection Phones = new PhoneClasses.clsPhoneCollection();
        //set the data source to the list of phones in the collection 
        lstPhones.DataSource = Phones.PhoneList;
        //set the name of the primary key 
        lstPhones.DataValueField = "PhoneID";
        //set the data field to display 
        lstPhones.DataTextField = "PhoneID";
        //bind the data to the list 
        lstPhones.DataBind(); 
    }

    void DisplayStaff()
    {
        //create an instance of the county collection 
        PhoneClasses.clsStaffCollection Staff = new PhoneClasses.clsStaffCollection();
        //set the data source to the list of counties in the collection
        lstStaff.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaff.DataValueField = "StaffID";
        //set the data field to display
        lstStaff.DataTextField = "FirstName";
        //bind the data to the list
        lstStaff.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is new record 
        Session["AddressNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("APhone.aspx"); 
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 PhoneID; 
        //if a record has been selected from the list 
        if (lstPhones.SelectedIndex != -1)
        {
            //get the primary key of the record to delete 
            PhoneID = Convert.ToInt32(lstPhones.SelectedValue);
            //store the data in the session object 
            Session["PhoneID"] = PhoneID;
            //redirect to the delete page 
            Response.Redirect("Delete.aspx"); 
        }
        //if no record has been selected
        else
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list"; 
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 PhoneID;
        //if a record has been selected from the list 
        if (lstPhones.SelectedIndex != -1)
        {
            //get the primary key of the record to delete 
            PhoneID = Convert.ToInt32(lstPhones.SelectedValue);
            //store the data in the session object 
            Session["PhoneID"] = PhoneID;
            //redirect to the delete page 
            Response.Redirect("APhone.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error 
            lblError.Text = "Please select a record to update from the list";
        }
    }
}



