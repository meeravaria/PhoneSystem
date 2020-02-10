using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace Phone_Testing
{
    [TestClass]
    public class tstPhoneCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsPhoneCollection AllPhone = new clsPhoneCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllPhone); 
        } 
    }
}
