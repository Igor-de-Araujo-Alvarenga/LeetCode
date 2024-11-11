using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class ZigZagConversion
    {
        public static string Execute(string s, int numRows)
        {
            if (numRows == 1 || numRows >= s.Length) return s;

            var rows = new StringBuilder[numRows];
            for (int i = 0; i < numRows; i++) rows[i] = new StringBuilder();

            int currentRow = 0;
            bool goingDown = false;

            foreach (char c in s)
            {
                rows[currentRow].Append(c);
                if (currentRow == 0 || currentRow == numRows - 1) goingDown = !goingDown;
                currentRow += goingDown ? 1 : -1;
            }

            return String.Concat<StringBuilder>(rows);        
        }
    }
}
