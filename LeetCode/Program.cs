using LeetCode.Algorithms;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var l1 = new ListNode { val = 2 , next = new ListNode { val = 4, next = new ListNode { val = 3 } } };
            var l2 = new ListNode { val = 5, next = new ListNode { val = 6 } };
            AddTwoNumbers.Execute(l1, l2);
        }
    }
}