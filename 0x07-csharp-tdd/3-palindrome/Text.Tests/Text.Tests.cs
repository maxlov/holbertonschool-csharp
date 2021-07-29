using NUnit.Framework;
using System;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void PanamaPalindrome()
        {
            string test = "A man, a plan, a canal: Panama.";
            Assert.IsTrue(Text.Str.IsPalindrome(test));
        }

        [Test]
        public void BadPalindrome()
        {
            string test = "A, a , a nal: Pama.";
            Assert.IsFalse(Text.Str.IsPalindrome(test));
        }

        [Test]
        public void EmptyPalindrome()
        {
            string test = "";
            Assert.IsTrue(Text.Str.IsPalindrome(test));
        }
    }
}