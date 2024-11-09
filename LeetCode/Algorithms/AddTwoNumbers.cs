using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class AddTwoNumbers
    {
        /// <summary>
        /// The technique used here is iteration
        /// </summary>
        public static ListNode Execute(ListNode l1, ListNode l2)
        {
            return Calculation(l1,l2);
        }

        private static ListNode Calculation(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode node = new ListNode(0);
            ListNode current = node;

            while (l1 != null || l2 != null || carry != 0)
            {
                int l1Val = l1?.val ?? 0;
                int l2Val = l2?.val ?? 0;

                int sum = l1Val + l2Val + carry;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);

                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return node.next;
        }
    }
}
