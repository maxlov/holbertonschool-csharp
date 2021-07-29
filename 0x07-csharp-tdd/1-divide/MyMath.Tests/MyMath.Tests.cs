using NUnit.Framework;
using System;
using System.IO;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void MatrixDivided()
        {
            int[,] myMatrix = new int[,] {{5, 10}, {15, 20}, {25, 30}};
            int[,] expected = new int[,] {{1, 2}, {3, 4}, {5, 6}};
            Assert.AreEqual(expected, MyMath.Matrix.Divide(myMatrix, 5));
        }

        [Test]
        public void MatrixIsNew()
        {
            int[,] myMatrix = new int[,] {{5, 10}, {15, 20}, {25, 30}};
            int[,] expected = new int[,] {{1, 2}, {3, 4}, {5, 6}};
            Assert.AreNotEqual(myMatrix, MyMath.Matrix.Divide(myMatrix, 5));
        }

        [Test]
        public void MatrixNull()
        {
            Assert.AreEqual(null, MyMath.Matrix.Divide(null, 5));
        }

        [Test]
        public void MatrixDivideZero()
        {
            int[,] myMatrix = new int[,] {{5, 10}, {15, 20}, {25, 30}};
            StringWriter stringWriter = new StringWriter();
            TextWriter originalOutput = Console.Out;
            Console.SetOut(stringWriter);
            Assert.AreEqual(null, MyMath.Matrix.Divide(myMatrix, 0));
            StringAssert.StartsWith("Num cannot be 0", stringWriter.ToString());
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}