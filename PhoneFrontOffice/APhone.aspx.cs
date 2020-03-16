using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class APhone : System.Web.UI.Page
{
    Int32 PhoneID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of phones to be processed 
        PhoneID = Convert.ToInt32(Session["PhoneID"]);
        if (IsPostBack == false)
        {
            //populate the list of phones 
            DisplayPhones(); 
            //if this is not a new record 
            if(PhoneID != -1)
            {
                //display the current data for the record 
                DisplayPhones(); 
            }
        }
        
    }

    //function for adding new records 
     void Add()
     {
        //create an instance of the phone book
        PhoneClasses.clsPhoneCollection PhoneBook = new PhoneClasses.clsPhoneCollection();
        //validate the data on the web form 
        String Error = PhoneBook.ThisPhone.Valid(txtCapacity.Text,txtPrice.Text, txtColour.Text, txtDateAdded.Text, txtDescription.Text, txtMake.Text, txtModel.Text); 
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user 
            PhoneBook.ThisPhone.Capacity = Convert.ToInt32(txtCapacity.Text); 
            PhoneBook.ThisPhone.Price = Convert.ToDecimal(txtPrice.Text);
            PhoneBook.ThisPhone.Colour = txtColour.Text;
            PhoneBook.ThisPhone.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            PhoneBook.ThisPhone.Description = txtDescription.Text;
            PhoneBook.ThisPhone.Make = txtMake.Text;
            PhoneBook.ThisPhone.Model = txtModel.Text;
            PhoneBook.ThisPhone.StockStatus = Convert.ToBoolean(chkStockStatus.Checked);
            PhoneBook.ThisPhone.Active = Convert.ToBoolean(chkActive.Checked);
            //add the record 
            PhoneBook.Add();
            //all done so redirect back to the main page 
            Response.Redirect("Default.aspx"); 
        }
        
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data entered : " + "  " + Error;
        }
        
     }


    //function for updating new records 
    void Update()
    {
        //create an instance of the phone book
        PhoneClasses.clsPhoneCollection PhoneBook = new PhoneClasses.clsPhoneCollection();
        //validate the data on the web form 
        String Error = PhoneBook.ThisPhone.Valid(txtCapacity.Text, txtPrice.Text, txtColour.Text, txtDateAdded.Text, txtDescription.Text, txtMake.Text, txtModel.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update 
            PhoneBook.ThisPhone.Find(PhoneID);
            //get the data entered by the user 
            PhoneBook.ThisPhone.Capacity = Convert.ToInt32(txtCapacity.Text);
            PhoneBook.ThisPhone.Price = Convert.ToDecimal(txtPrice.Text);
            PhoneBook.ThisPhone.Colour = txtColour.Text;
            PhoneBook.ThisPhone.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            PhoneBook.ThisPhone.Description = txtDescription.Text;
            PhoneBook.ThisPhone.Make = txtMake.Text;
            PhoneBook.ThisPhone.Model = txtModel.Text;
            PhoneBook.ThisPhone.StockStatus = Convert.ToBoolean(chkStockStatus.Checked);
            PhoneBook.ThisPhone.Active = Convert.ToBoolean(chkActive.Checked);
            //update the record 
            PhoneBook.Update();
            //all done so redirect back to the main page 
            Response.Redirect("Default.aspx");
        }

        else
        {
            //report an error 
            lblError.Text = "There were problems with the data entered : " + "  " + Error;
        }

    }


    //function for updating new records 
    void DisplayPhones()
    {
        //create an instance of the phone book
        clsPhoneCollection PhoneBook = new clsPhoneCollection();
        //find the record to update 
        PhoneBook.ThisPhone.Find(PhoneID);
        //display the data for this record 
        txtCapacity.Text = PhoneBook.ThisPhone.Capacity.ToString();
        txtPrice.Text = PhoneBook.ThisPhone.Price.ToString();
        txtColour.Text = PhoneBook.ThisPhone.Colour; 
        txtDateAdded.Text = PhoneBook.ThisPhone.DateAdded.ToString();
        txtDescription.Text = PhoneBook.ThisPhone.Description;
        txtMake.Text = PhoneBook.ThisPhone.Make;
        txtModel.Text = PhoneBook.ThisPhone.Model;
        chkStockStatus.Checked = PhoneBook.ThisPhone.StockStatus;
        chkActive.Checked = PhoneBook.ThisPhone.Active;
    }
    
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (PhoneID == -1)
        {
             //add the new record 
            Add();
        }

        else
        {
            //update the record 
            Update(); 
        }

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx"); 
    }
}