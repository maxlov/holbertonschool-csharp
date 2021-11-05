using NUnit.Framework;
using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class InventoryTests
    {
        Item item;
        User user;
        int quantity;

        [SetUp]
        ///<summary>Sets up variables for tests</summary>
        public void InventorySetup()
        {
            user = new User("Youngster Joey");
            item = new Item("pokeball");
            quantity = 5;
        }

        [Test]
        ///<summary>Tests to make sure each value of Inventory class is created.</summary>
        public void TestInitializeInventory()
        {
            Inventory InventoryInst = new Inventory(user, item, quantity);
            Assert.AreEqual(InventoryInst.user_id, user.id);
            Assert.AreEqual(InventoryInst.item_id, item.id);
            Assert.AreEqual(InventoryInst.quantity, quantity);
            Assert.IsInstanceOf<string>(InventoryInst.id);
            Assert.IsInstanceOf<DateTime>(InventoryInst.date_created);
            Assert.IsInstanceOf<DateTime>(InventoryInst.date_updated);
        }
    }
}