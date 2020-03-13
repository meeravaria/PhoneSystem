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
        lstPhones.DataTextField = "PhoneID";
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

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all phones
        DisplayPhone();
    }

    Int32 DisplayPhone()
    {
        Int32 PhoneID; //Var to store the primary key 
        Int32 Capacity; //Var to store the Capacity 
        Decimal Price; //Var to store the Price 
        String Colour; //Var to store the Colour 
        DateTime DateAdded; // Var to store the DateAdded 
        String Description; //Var to store the Description 
        String Make; //Var to store the Make
        String Model; //Var to store the Model 
        Boolean Active; //Var to store the Active 
        Boolean StockStatus; //Var to store the StockStatus 
        ;//Create an instance of the address book class 
        clsPhoneCollection Phone = new clsPhoneCollection();
        Int32 RecordCount; //Var to store the count of records 
        Int32 Index = 0; //Var to store the index for the loop
        RecordCount = Phone.Count; //get the count of records 
        lstPhones.Items.Clear();
        while (Index < RecordCount) //While there are records to process
        {
            PhoneID = Phone.PhoneList[Index].PhoneID; //get primary key 
            Capacity = Phone.PhoneList[Index].Capacity; //get Capacity
            Price = Phone.PhoneList[Index].Price; //get Price
            Colour = Phone.PhoneList[Index].Colour; //get Colour
            DateAdded = Phone.PhoneList[Index].DateAdded; //get DateAdded
            Description = Phone.PhoneList[Index].Description; //get Description
            Make = Phone.PhoneList[Index].Make; //get Make
            Model = Phone.PhoneList[Index].Model; //get Model
            Active = Phone.PhoneList[Index].Active; //get Active
            StockStatus = Phone.PhoneList[Index].StockStatus; //get StockStatus
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(PhoneID.ToString() + " - " + Make + " ");
            lstPhones.Items.Add(NewEntry);
            Index++;
        }
        return RecordCount; //return the count of records found

    }

   
}



