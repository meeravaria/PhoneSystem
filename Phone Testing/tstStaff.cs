using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace Phone_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //test to see that is exists 
            Assert.IsNotNull(AnAddress);
        }
    }
}
