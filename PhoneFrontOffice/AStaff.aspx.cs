using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class AStaff : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of staff to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if(IsPostBack == false)
        {
            //populate the list of staff
            DisplayStaff();
            //if this is not a new record
            if (StaffID !=1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }


    void DisplayStaff()
    {
        //create an instance of the staff system
        clsStaffCollection StaffSystem = new clsStaffCollection();
        //find the record to update
        StaffSystem.ThisStaff.Find(StaffID);
        //display the data for this record 
        txtDOB.Text = StaffSystem.ThisStaff.DateOfBirth;
        txtFirstName.Text = StaffSystem.ThisStaff.FirstName;
        txtLastName.Text = StaffSystem.ThisStaff.LastName;
        txtPostcode.Text = StaffSystem.ThisStaff.PostCode;
        txtStreet.Text = StaffSystem.ThisStaff.Street;
        Active.Checked = StaffSystem.ThisStaff.Active;
        lstCounty.SelectedValue = StaffSystem.ThisStaff.County.ToString();
        lstGender.SelectedValue = StaffSystem.ThisStaff.Gender.ToString();
        
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the StaffID
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AStaff.County = Convert.ToString(lstCounty.Text);
        AStaff.Street = Convert.ToString(txtStreet.Text);
        AStaff.PostCode = Convert.ToString(txtPostcode.Text);
        AStaff.DateOfBirth = Convert.ToString(txtDOB.Text);
        AStaff.FirstName = Convert.ToString(txtFirstName.Text);
        AStaff.LastName = Convert.ToString(txtLastName.Text);
        AStaff.Gender = Convert.ToBoolean(lstGender.Text);
        AStaff.Telephone = Convert.ToInt32(txtTelephone.Text);
        AStaff.Active = Convert.ToBoolean(Active.Text);
        //store the staff in the session object 
        Session["AStaff"] = AStaff;
        //redirect to the viewer page
        Response.Redirect("AStaffViewer.aspx");

        if (StaffID == -1)
        {
             //add the new record
             Add();
        }
        else
        {
            //update the record
            Update();
        }
       
        //all done so redirect back to main page
        Response.Redirect("DefaultStaff.aspx");
    }

        //function for adding new records
        void Add()
        {
        //create an instance of the staff 
        clsStaffCollection StaffSystem = new clsStaffCollection();
        //validate the data on the web forms
        String Error =  StaffSystem.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtPostcode.Text, txtDOB.Text, txtStreet.Text, txtTelephone.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            StaffSystem.ThisStaff.County = lstCounty.Text;
            StaffSystem.ThisStaff.FirstName = txtFirstName.Text;
            StaffSystem.ThisStaff.LastName = txtLastName.Text;
            StaffSystem.ThisStaff.Gender = Convert.ToBoolean(lstGender.Text);
            StaffSystem.ThisStaff.DateOfBirth = txtDOB.Text;
            StaffSystem.ThisStaff.Street = txtStreet.Text;
            StaffSystem.ThisStaff.PostCode = txtPostcode.Text;
            StaffSystem.ThisStaff.Telephone = Convert.ToInt32(txtPostcode.Text);
            StaffSystem.ThisStaff.Active = Active.Checked;
            //add the record 
            StaffSystem.Add();
            //all done so redirect back to the main page
            Response.Redirect("DefaultStaff.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error; 
        }

        }

        //function for updating records
        void Update()
        {
        //create an instance of the staff
        PhoneClasses.clsStaffCollection StaffSystem = new PhoneClasses.clsStaffCollection();
        //validate the data on the web form
        String Error = StaffSystem.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtPostcode.Text, txtDOB.Text, txtStreet.Text, txtTelephone.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            //StaffSystem.ThisStaff.Find(StaffID);
            //get the data entered by the user
            StaffSystem.ThisStaff.County = lstCounty.Text;
            StaffSystem.ThisStaff.FirstName = txtFirstName.Text;
            StaffSystem.ThisStaff.LastName = txtLastName.Text;
            StaffSystem.ThisStaff.Gender = Convert.ToBoolean(lstGender.Text);
            StaffSystem.ThisStaff.DateOfBirth = txtDOB.Text;
            StaffSystem.ThisStaff.Street = txtStreet.Text;
            StaffSystem.ThisStaff.PostCode = txtPostcode.Text;
            StaffSystem.ThisStaff.Telephone = Convert.ToInt32(txtPostcode.Text);
            StaffSystem.ThisStaff.Active = Active.Checked;
            //update the record
            StaffSystem.Update();
            //all done so redirect back to the main page
            Response.Redirect("DefaultStaff.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with data entered" + Error;
        }
        }

    protected void Active_CheckedChanged(object sender, EventArgs e)
        {

        }
    }