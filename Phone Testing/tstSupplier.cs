using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace Phone_Testing
{
    [TestClass]
    public class tstSupplier
    {
        public tstSupplier()
        {
        }

        [TestMethod]
        public void InstanceOk()
        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //comment
            clsSupplier ASupplier = new clsSupplier();
            //comment
            Boolean TestData = true;
            //comment
            ASupplier.Active = TestData;
            //comment
            Assert.AreEqual(ASupplier.Active, TestData);
        }
        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            //comment
            clsSupplier ASupplier = new clsSupplier();
            //comment
            Int32 TestData = 1;
            //comment
            ASupplier.SupplierID = TestData;
            //comment
            Assert.AreEqual(ASupplier.SupplierID, TestData);
        }
        [TestMethod]
        public void ReferencePropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            //comment
            Int32 TestData = 128;
            //comment
            ASupplier.Reference = TestData;
            //comment
            Assert.AreEqual(ASupplier.Reference, TestData);
        }
        [TestMethod]
        public void DescriptionPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            //comment
            string TestData = "Samsung";
            //comment
            ASupplier.Description = TestData;
            //comment
            Assert.AreEqual(ASupplier.Description, TestData);
        }
        [TestMethod]
        public void CategoryPropertyOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            //comment
            string TestData = "Phone";
            //comment
            ASupplier.Category = TestData;
            //comment
            Assert.AreEqual(ASupplier.Category, TestData);
        }
    }

}
