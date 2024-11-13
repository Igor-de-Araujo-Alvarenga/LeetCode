using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutions
{
    public class PalindromeNumberTests
    {

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void TestResult_PalindromeNumber(int x, bool expected)
        {
            //act
            var result = PalindromeNumber.Execute(x);
            //assert
            Assert.Equal(expected, result);
        }
    }
}
