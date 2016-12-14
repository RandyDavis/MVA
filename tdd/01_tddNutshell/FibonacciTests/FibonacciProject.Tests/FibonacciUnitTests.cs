using System;
using Xunit;
using FibonacciProject;

namespace FibonacciProject.Tests
{
    public class FibonacciUnitTests
    {
        [Fact]
        public void Fib_Given0_Return0()
        {
            // arrange
            int n = 0;

            // act
            int result = Fibonacci.Fib(n);

            // assert
            Assert.Equal(0, result);
        }
    }

}
