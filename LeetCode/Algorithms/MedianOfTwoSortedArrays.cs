using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public static class MedianOfTwoSortedArrays
    {
        /// <summary>
        /// Tecnique used here is Binary Search: The binary search is performed on the smaller array, so the time complexity is 
        /// O(logmin(m, n)), where m and n are the lengths of the two arrays.
        /// </summary>
        public static double Execute(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return Execute(nums2, nums1);

            int m = nums1.Length;
            int n = nums2.Length;
            int totalLeft = (m + n + 1) / 2;

            int left = 0;
            int right = m;

            while (left < right)
            {
                var a = left + (right - left) / 2;
                var b = totalLeft - a;

                if (nums1[a] < nums2[b - 1])
                    left = a + 1;
                else
                    right = a;
            }

            var i = left;
            var j = totalLeft - i;

            int nums1LeftMax = i == 0 ? int.MinValue : nums1[i - 1];
            int nums1RightMin = i == m ? int.MaxValue : nums1[i];
            int nums2LeftMax = j == 0 ? int.MinValue : nums2[j - 1];
            int nums2RightMin = j == n ? int.MaxValue : nums2[j];

            if ((m + n) % 2 == 1)
                return Math.Max(nums1LeftMax, nums2LeftMax);
            else
                return (Math.Max(nums1LeftMax, nums2LeftMax) + Math.Min(nums1RightMin, nums2RightMin)) / 2.0;
        }
    }
}
