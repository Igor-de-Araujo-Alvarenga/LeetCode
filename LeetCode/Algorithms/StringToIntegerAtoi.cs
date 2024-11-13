using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class StringToIntegerAtoi
    {
        public static int Execute(string s)
        {
            var newNumber = string.Empty;
            var sign = false;
            foreach (var c in s)
            {
                if(char.IsLetter(c) || c.Equals('.') || (char.IsWhiteSpace(c) && !string.IsNullOrEmpty(newNumber)))
                    break;
                if ((c.Equals('-') || c.Equals('+')) && sign)
                    break;

                if ((c.Equals('-') || c.Equals('+')) && !sign)
                {
                    if (!string.IsNullOrEmpty(newNumber))
                        break;
                    newNumber += c;
                    sign = true;
                }
                if(char.IsNumber(c))
                    newNumber += c;
            }
            if (double.TryParse(newNumber, out double result64))
            {
                if (Int32.TryParse(newNumber, out int result32))
                {
                    return result32;
                }
                else
                {
                    return result64 >= Int32.MaxValue ? Int32.MaxValue : Int32.MinValue;
                }
            }
            else
                return 0;
        }
    }
}