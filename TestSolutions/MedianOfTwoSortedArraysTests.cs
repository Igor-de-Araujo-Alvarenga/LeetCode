using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutions
{
    public class MedianOfTwoSortedArraysTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.0)]  
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]  
        [InlineData(new int[] { }, new int[] { 1, 2, 3, 4, 5 }, 3.0)] 
        public void FindMedianSortedArrays_VariousCases_ReturnsCorrectMedian(int[] nums1, int[] nums2, double expectedMedian)
        {
            // Act
            double result = MedianOfTwoSortedArrays.Execute(nums1, nums2);
            // Assert
            Assert.Equal(expectedMedian, result);
        }
    }
}
