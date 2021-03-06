﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class DefaultStaff : System.Web.UI.Page
{

    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {

        ///get the number of staff to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //populate the list of staff
            DisplayPostCode();
        }

    }

    void DisplayPostCode()
    {
        //create an instance of the county collection 
        PhoneClasses.clsStaffCollection Staff = new PhoneClasses.clsStaffCollection();
        //set the data source to the list of counties in the collection
        lstStaff.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaff.DataValueField = "StaffID";
        //set the data field to display
        lstStaff.DataTextField = "PostCode";
        //bind the data to the list
        lstStaff.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AStaff.aspx");

    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 StaffID;
        //if a record has been selected from the list 
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key of the record to delete 
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object 
            Session["StaffID"] = StaffID;
            //redirect to the delete page 
            Response.Redirect("AStaff.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error 
            lblError.Text = "Please select a record to update from the list";
        }
    }



    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else //if no record has been selected
        {
            //display and errpr
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDisplayAll_Click1(object sender, EventArgs e)
    {
        ////display all staff 
        DisplayPostCode("");
    }

    

     protected void btnApply_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayPostCode(txtStaffSearch.Text);
            lblError.Text = RecordCount + " Record Found";

        }


    Int32 DisplayPostCode(string PostCodeFilter)
    {
        Int32 StaffID; //Var to store the primary key  
        String PostCode; //Var to store the postcode
        String FirstName; //Var to store the firstname 
        clsStaffCollection PostCodeSearch = new clsStaffCollection();//Create an instance of the staff search
        PostCodeSearch.ReportByPostCode(PostCodeFilter);//invoke the staff postcode filter
        Int32 RecordCount; //Var to store the count of records 
        Int32 Index = 0; //Var to store the index for the loop
        RecordCount = PostCodeSearch.Count; //get the count of records 
        lstStaff.Items.Clear(); //clear the list box
        while (Index < RecordCount) //While there are records to process
        {
            StaffID = PostCodeSearch.StaffList[Index].StaffID; //get primary key 
            PostCode = PostCodeSearch.StaffList[Index].PostCode; //get postcode
            FirstName = PostCodeSearch.StaffList[Index].FirstName; //get firstname
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(PostCode + " " + FirstName, StaffID.ToString());
            lstStaff.Items.Add(NewEntry);
            Index++;
        }
        return RecordCount; //return the count of records found

    }

    protected void lstStaff_SelectedIndexChanged1(object sender, EventArgs e)

    {

    }

    protected void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    //protected void lstStaff_SelectedIndexChanged1(object sender, EventArgs e)

    //{

    //}


    //protected void btnApply_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnDisplayAll_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnAdd_Click1(object sender, EventArgs e)
    //{

    //}

    //protected void btnDelete_Click(object sender, EventArgs e)
    //{

    //}

    //protected void btnEdit_Click(object sender, EventArgs e)
    //{

    //}







   
}

   