using LeetCode;

namespace TestSolutions
{
    public class TwoSumTests
    {
        [Fact]
        public void TestResultTwoSum()
        {
            var expected1 = new int[] { 0, 1 };
            var expected2 = new int[] { 1, 2 };
            var expected3 = new int[] { 0, 1 };

            var result1 = TwoSum.Execute(new int[] { 2, 7, 11, 15 }, 9);
            var result2 = TwoSum.Execute(new int[] { 3, 2, 4 }, 6);
            var result3 = TwoSum.Execute(new int[] {3,3}, 6);

            Assert.NotNull(result1);
            Assert.True(result1.Length == 2);
            Assert.Equal(expected1[0], result1[0]);
            Assert.Equal(expected1[1], result1[1]);

            Assert.NotNull(result2);
            Assert.True(result2.Length == 2);
            Assert.Equal(expected2[0], result2[0]);
            Assert.Equal(expected2[1], result2[1]);

            Assert.NotNull(result3);
            Assert.True(result3.Length == 2);
            Assert.Equal(expected3[0], result3[0]);
            Assert.Equal(expected3[1], result3[1]);
        }
    }
}