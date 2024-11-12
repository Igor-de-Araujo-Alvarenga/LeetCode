using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class ReverseInteger
    {
        public static int Execute(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                    return 0;
                if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
                    return 0;
                result = result * 10 + digit;
            }
            return result;
        }
    }
}