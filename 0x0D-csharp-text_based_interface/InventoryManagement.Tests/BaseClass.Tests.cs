using NUnit.Framework;
using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class BaseClassTests
    {
        [Test]
        ///<summary>Tests to make sure each value of baseclass is created.</summary>
        public void TestInitializeBaseClass()
        {
            BaseClass baseInstance = new BaseClass();
            Assert.IsInstanceOf<string>(baseInstance.id);
            Assert.IsInstanceOf<DateTime>(baseInstance.date_created);
            Assert.IsInstanceOf<DateTime>(baseInstance.date_updated);
        }

        [Test]
        ///<summary>Tests if creation and update are not equal.</summary>
        public void TestDatetimeBaseClass()
        {
            BaseClass baseInstance = new BaseClass();
            Assert.AreNotEqual(baseInstance.date_created, baseInstance.date_updated);
        }
    }
}