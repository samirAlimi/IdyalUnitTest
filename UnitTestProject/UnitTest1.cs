using NUnit.Framework;
using System;
using IdyalUnitTest;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
    
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello, we will do some tests", Program.HelloMessage());
        }

        [Test]
        public void Add()
        {
            Program math = new Program();
            Assert.AreEqual(50, math.Add(20, 30));
        }
        [Test]
        public void Sub()
        {
            Program math = new Program();
            Assert.AreEqual(25, math.Sub(40, 15));
        }
        [Test]
        public void Prod()
        {
            Program math = new Program();
            Assert.AreEqual(50, math.Prod(5, 10));
        }
        [Test]
        public void Diviser()
        {
            Program math = new Program();
            Assert.AreEqual(5, math.Diviser(100, 20));
        }

        [Test]
        public void ReturnFalseGivenValueOf1()
        {
            Program test = new Program();
            var result = test.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            Program test = new Program();
            var result = test.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");
        }
        [Test]
        public void ReturnTrueGivenValueOf2()
        {
            Program test = new Program();
            var result = test.IsPrime(2);
            Assert.IsTrue(result, "2 should be prime");
        }
    }
}
