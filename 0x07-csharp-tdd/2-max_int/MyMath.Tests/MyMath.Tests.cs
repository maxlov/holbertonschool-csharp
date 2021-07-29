using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void ReturnMax()
        {
            List<int> nums = new List<int>() {-100, 10, 0, 45, 45, 69};
            Assert.AreEqual(69, MyMath.Operations.Max(nums));
        }

        [Test]
        public void Return0()
        {
            List<int> nums = new List<int>();
            Assert.AreEqual(0, MyMath.Operations.Max(nums));
        }
    }
}