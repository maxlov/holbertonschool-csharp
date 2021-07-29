using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Hello()
        {
            string s = "hEllo";
            Assert.AreEqual(0, Text.Str.UniqueChar(s));
        }

        [Test]
        public void NoUnique()
        {
            string s = "aaaa";
            Assert.AreEqual(-1, Text.Str.UniqueChar(s));
        }

        [Test]
        public void Middle()
        {
            string s = "aaHaa";
            Assert.AreEqual(2, Text.Str.UniqueChar(s));
        }
    }
}