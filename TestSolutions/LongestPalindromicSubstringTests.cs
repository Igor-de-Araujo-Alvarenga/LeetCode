using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutions
{
    public class LongestPalindromicSubstringTests
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("ac", "a")] // Example with two characters (no palindrome longer than 1)
        [InlineData("racecar", "racecar")] // Example with a full palindrome
        public void LongestPalindrome_ReturnsCorrectResult(string input, string expected)
        {
            // Act
            var result = LongestPalindromicSubstring.Execute(input);
            // Assert
            Assert.Equal(expected, result);
        }
    }

}

