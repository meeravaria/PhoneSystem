using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Phone_Testing
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSupplier AnAddress = new clsSupplier();
            Assert.IsNotNull(AnAddress);
        }
    }
}
