using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace Phone_Testing
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);
        }
    }
}
