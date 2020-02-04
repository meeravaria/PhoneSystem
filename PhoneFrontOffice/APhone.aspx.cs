using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class APhone : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create 
        clsPhone APhone = new clsPhone();
        //capture the phone id
        //APhone.PhoneID = txtPhoneID.Text;
        //store the phone in the session object 
        Session["APhone"] = APhone;
        //redirect to the viewer page 
        Response.Redirect("APhoneViewer.aspx"); 
    
        //create some test data to assign to the property 
        Int32 TestData = 1;
        //assign the data to the property
        APhone.PhoneID = TestData;
       
    }
}