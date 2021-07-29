using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void camelCase()
        {
            string s = "camelCase";
            Assert.AreEqual(2, Text.Str.CamelCase(s));
        }

        [Test]
        public void emptyString()
        {
            string s = "";
            Assert.AreEqual(0, Text.Str.CamelCase(s));
        }

        [Test]
        public void lower()
        {
            string s = "camelcase";
            Assert.AreEqual(1, Text.Str.CamelCase(s));
        }
    }
}