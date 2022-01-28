using NUnit.Framework;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void exp2_10_1024returned()
        {
            //arrange
            double x = 2;
            double y = 10;
            double expected = 1024;

            //act
            Program p = new Program();
            double value = Math.Pow(x, y);

            //assert
            Assert.AreEqual(expected, value);
        }
    }
}