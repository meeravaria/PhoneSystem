using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PhoneClasses;

public partial class APhoneViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsPhone APhone = new clsPhone();
        //get the data from the session object 
        APhone = (clsPhone)Session["APhone"];
        //display the phone id number for this entry 
        Response.Write(APhone.Model);
        Response.Write(APhone.Make);
        Response.Write(APhone.Capacity);
        Response.Write(APhone.Price);
        Response.Write(APhone.Colour);
        Response.Write(APhone.DateAdded);
        Response.Write(APhone.StockStatus);
    }
}