using PhoneClasses;
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
        lstPhones.DataTextField = "Make";
        //bind the data to the list 
        lstPhones.DataBind();
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
            Response.Redirect("PhoneDelete.aspx");
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

    protected void lstPhones_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PhoneID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("APhone.aspx");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count 
        Int32 RecordCount;
        RecordCount = DisplayPhone(txtPhoneSearch.Text);
        lblError.Text = RecordCount + " Record Found";
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all phones
        DisplayPhone("");
    }

    Int32 DisplayPhone(string MakeFilter) 
    {
        Int32 PhoneID; //Var to store the primary key  
        String Make; //Var to store the Make
        String Model; //Var to store the Model 
        clsPhoneCollection MakeSearch= new clsPhoneCollection();//Create an instance of the address book class 
        MakeSearch.ReportByMake(MakeFilter);//invoke the phone make filter
        Int32 RecordCount; //Var to store the count of records 
        Int32 Index = 0; //Var to store the index for the loop
        RecordCount = MakeSearch.Count; //get the count of records 
        lstPhones.Items.Clear(); //clear the list box
        while (Index < RecordCount) //While there are records to process
        {
            PhoneID = MakeSearch.PhoneList[Index].PhoneID; //get primary key 
            Make = MakeSearch.PhoneList[Index].Make; //get Make
            Model = MakeSearch.PhoneList[Index].Model; //get Model
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(Make + " " + Model, PhoneID.ToString());
            lstPhones.Items.Add(NewEntry);
            Index++;
        }
        return RecordCount; //return the count of records found

    }

   
}



