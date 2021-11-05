using NUnit.Framework;
using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class UserTests
    {
        string name;

        [SetUp]
        ///<summary>Sets up variables for tests</summary>
        public void UserSetup()
        {
            name = "Youngster Joey";
        }

        [Test]
        ///<summary>Tests to make sure each value of User class is created.</summary>
        public void TestInitializeUser()
        {
            User UserInst = new User(name);
            Assert.AreEqual(name, UserInst.name);
            Assert.IsInstanceOf<string>(UserInst.id);
            Assert.IsInstanceOf<DateTime>(UserInst.date_created);
            Assert.IsInstanceOf<DateTime>(UserInst.date_updated);
        }
    }
}