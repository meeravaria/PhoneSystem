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
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }
    }
}
