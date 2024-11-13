using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutions
{
    public class StringToIntegerAtoiTests
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("   -042", -42)]
        [InlineData("1337c0d3", 1337)]
        [InlineData("0-1", 0)]
        [InlineData("words and 987", 0)]
        public void TestResultStringToInteger(string s, int expected)
        {
            //Act
            var result = StringToIntegerAtoi.Execute(s);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
