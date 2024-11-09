using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolutions
{
    public class AddTwoNumbersTests
    {

        [Fact]
        public void TestResultAddTwoNumbers1()
        {
            // Arrange
            var l1 = BuildListNode(new int[] { 2, 4, 3 });
            var l2 = BuildListNode(new int[] { 5, 6, 4 });
            var expected = BuildListNode(new int[] { 7, 0, 8 });

            // Act
            var result = LeetCode.Algorithms.AddTwoNumbers.Execute(l1, l2);

            // Assert
            AssertEqual(result, expected);
        }

        [Fact]
        public void TestResultAddTwoNumbers2()
        {
            // Arrange
            var l1 = BuildListNode(new int[] { 0 });
            var l2 = BuildListNode(new int[] { 0 });
            var expected = BuildListNode(new int[] { 0 });

            // Act
            var result = LeetCode.Algorithms.AddTwoNumbers.Execute(l1, l2);

            // Assert
            AssertEqual(result, expected);
        }

        [Fact]
        public void TestResultAddTwoNumbers3()
        {
            // Arrange
            var l1 = BuildListNode(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            var l2 = BuildListNode(new int[] { 9, 9, 9, 9 });
            var expected = BuildListNode(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });

            // Act
            var result = LeetCode.Algorithms.AddTwoNumbers.Execute(l1, l2);

            // Assert
            AssertEqual(result, expected);
        }

        private ListNode BuildListNode(int[] values)
        {
            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        private void AssertEqual(ListNode result, ListNode expected)
        {
            while (result != null && expected != null)
            {
                Assert.Equal(result.val, expected.val);
                result = result.next;
                expected = expected.next;
            }

            Assert.Null(result); 
            Assert.Null(expected);
        }
    }
}
