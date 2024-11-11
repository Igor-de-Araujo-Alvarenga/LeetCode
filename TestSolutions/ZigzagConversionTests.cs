using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutions
{
    public class ZigzagConversionTests
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void Test_ZigzagConversion(string input, int numRows, string expectedOutput)
        {
            // Act
            string result = ZigZagConversion.Execute(input, numRows);
            // Assert
            Assert.Equal(expectedOutput, result);
        }
    }

}
