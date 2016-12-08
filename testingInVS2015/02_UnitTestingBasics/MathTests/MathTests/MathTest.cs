using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTests
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void TestAdd()
        {
            // arrange
            int num1 = 2;
            int num2 = 3;

            // act
            int sum = MyMath.Add(num1, num2);

            // assert
            Assert.AreEqual(5, sum);
        }
    }
}
