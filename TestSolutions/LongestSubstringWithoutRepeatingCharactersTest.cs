using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutions
{
    public class LongestSubstringWithoutRepeatingCharactersTest
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LongestSubstringWithoutRepeatingCharactersResultTest(string input, int expected)
        {
            //act
            var result = LongestSubstringWithoutRepeatingCharacters.Execute(input);
            //assert
            Assert.Equal(expected, result);
        }
    }
}
