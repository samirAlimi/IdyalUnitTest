using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IdyalUnitTest;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
    
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello, we will do some tests", Program.HelloMessage());
        }

        [TestMethod]
        public void Add()
        {
            Program math = new Program();
            Assert.AreEqual(50, math.Add(20, 30));
        }
        [TestMethod]
        public void Sub()
        {
            Program math = new Program();
            Assert.AreEqual(25, math.Sub(40, 15));
        }
        [TestMethod]
        public void Prod()
        {
            Program math = new Program();
            Assert.AreEqual(50, math.Prod(5, 10));
        }
        [TestMethod]
        public void Diviser()
        {
            Program math = new Program();
            Assert.AreEqual(5, math.Diviser(100, 20));
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            Program test = new Program();
            var result = test.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }
        /*[TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            Program test = new Program();
            var result = test.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");
        }*/
        [TestMethod]
        public void ReturnTrueGivenValueOf2()
        {
            Program test = new Program();
            var result = test.IsPrime(2);
            Assert.IsTrue(result, "2 should be prime");
        }
    }
}
