using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// Tecnique called sliding window
        /// </summary>
        public static int Execute(string s)
        {
            int left = 0, maxLength = 0;
            var charIndex = new Dictionary<char, int>();

            for (int right = 0; right < s.Length; right++)
            {
                if (charIndex.TryGetValue(s[right], out int prevIndex) && prevIndex >= left)
                    left = prevIndex + 1;

                charIndex[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
