using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
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
        //store the -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AStaff.aspx");
    }

    protected void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if(lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display and errpr
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
            {
            //get the primary key value of the record to edit 
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("AStaff.aspx");
            }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}



