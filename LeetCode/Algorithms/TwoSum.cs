using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class TwoSum
    {
        public static int[] Execute(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.ContainsKey(complement))
                    return new int[] { numDict[complement], i };
                if (!numDict.ContainsKey(nums[i]))
                    numDict[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}