using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeetCode.Algorithms;

namespace TestSolutions
{
    public class ReverseIntegerTests
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(2, 2)]
        public void Execute_ShouldReturnExpectedResult(int input, int expected)
        {
            // Act
            int result = ReverseInteger.Execute(input);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}