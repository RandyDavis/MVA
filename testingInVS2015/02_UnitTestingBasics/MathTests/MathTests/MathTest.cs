using System;
using Xunit;

namespace MathTests
{
    public class MathTest
    {
        [Fact]
        public void TestAdd()
        {
            // arrange
            int num1 = 2;
            int num2 = 3;

            // act
            int sum = MyMath.Add(num1, num2);

            // assert
            Assert.Equal(5, sum);
        }
    }
}
