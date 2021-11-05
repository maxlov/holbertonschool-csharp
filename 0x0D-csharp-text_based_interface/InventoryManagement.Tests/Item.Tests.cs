using NUnit.Framework;
using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class ItemTests
    {
        string name;
        float price;
        string desc;
        List<string> tags;

        [SetUp]
        ///<summary>Sets up variables for tests</summary>
        public void ItemSetup()
        {
            name = "pokeball";
            price = 300.00f;
            desc = "A device used to capture pokemon";
            tags = new List<string>();
            tags.Add("consumable");
            tags.Add("common");
        }

        [Test]
        ///<summary>Tests to make sure each value of item class is created.</summary>
        public void TestInitializeOptionalItem()
        {
            Item itemInst = new Item(name, desc, price, tags);
            Assert.AreEqual(name, itemInst.name);
            Assert.AreEqual(desc, itemInst.description);
            Assert.AreEqual(price, itemInst.price);
            Assert.AreEqual(tags, itemInst.tags);
            Assert.IsInstanceOf<string>(itemInst.id);
            Assert.IsInstanceOf<DateTime>(itemInst.date_created);
            Assert.IsInstanceOf<DateTime>(itemInst.date_updated);
        }

        [Test]
        ///<summary>Tests to make sure each value of item class is created.</summary>
        public void TestInitializeItem()
        {
            Item itemInst = new Item(name);
            Assert.AreEqual(name, itemInst.name);
            Assert.IsInstanceOf<string>(itemInst.id);
            Assert.IsInstanceOf<DateTime>(itemInst.date_created);
            Assert.IsInstanceOf<DateTime>(itemInst.date_updated);
        }
    }
}