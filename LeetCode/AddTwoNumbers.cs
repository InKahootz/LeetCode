using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddTwoNumbersSolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) => val = x;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            int val = (l1?.val ?? 0) + (l2?.val ?? 0);

            if (val >= 10)
            {
                result.val = val - 10;
                if (l1?.next != null)
                {
                    l1.next.val += 1;
                    result.next = AddTwoNumbers(l1.next, l2?.next);
                }
                else if (l2?.next != null)
                {
                    l2.next.val += 1;
                    result.next = AddTwoNumbers(l1?.next, l2.next);
                }
                else
                {
                    result.next = new ListNode(1);
                }
                return result;
            }
            if (l1 == null && l2 == null)
            {
                return null;
            }
            result.val = val;
            result.next = AddTwoNumbers(l1?.next, l2?.next); 
            return result;
        }
    }
}
