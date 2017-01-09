using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyAddTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Add_WhenPassed1And1_Returns2()
        {
            // arrange
            int x = 1;
            int y = 1;

            // act
            int total = Calc.Add(x, y);

            // assert
            Assert.AreEqual(2, total);
        }
    }
}
