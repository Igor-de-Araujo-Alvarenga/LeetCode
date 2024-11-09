using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class LongestPalindromicSubstring
    {
        public static string Execute(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            string longest = "";

            for (int i = 0; i < s.Length; i++)
            {
                string oddPalindrome = ExpandAroundCenter(s, i, i);
                if (oddPalindrome.Length > longest.Length)
                    longest = oddPalindrome;

                string evenPalindrome = ExpandAroundCenter(s, i, i + 1);
                if (evenPalindrome.Length > longest.Length)
                    longest = evenPalindrome;
            }
            return longest;
        }
        private static string ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return s.Substring(left + 1, right - left - 1);
        }
    }
}
