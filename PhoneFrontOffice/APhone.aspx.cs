using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class APhone : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of the class we want to create 
        clsPhone APhone = new clsPhone();
        //capture the model
        APhone.Model = txtModel.Text;
        //capture the make
        APhone.Make = txtMake.Text;
        //capture the capacity
        APhone.Capacity = Convert.ToInt32(txtCapacity.Text);
        //capture the price
        APhone.Price = Convert.ToDecimal(txtPrice.Text);
        //capture the colour
        APhone.Colour = txtColour.Text;
        //capture the date added
        APhone.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //capture the stock status 
        APhone.StockStatus = Convert.ToBoolean(chkStockStatus.Text);
        //store the phone in the session object 
        Session["APhone"] = APhone;
        //redirect to the viewer page 
        Response.Redirect("APhoneViewer.aspx"); 
    
       
       
       
    }
}