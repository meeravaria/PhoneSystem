﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
    }

    protected void Active_CheckedChanged(object sender, EventArgs e)
    {

    }
}