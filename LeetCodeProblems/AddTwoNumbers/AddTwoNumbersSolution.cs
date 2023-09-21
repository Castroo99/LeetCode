using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.AddTwoNumbers
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();
            var pointer = head;
            int overflow = 0;
            while (l1 != null || l2 != null)
            {
                overflow = (l1 is null ? 0 : l1.val) + (l2 is null ? 0 : l2.val) + overflow;
                pointer.next = new ListNode(overflow % 10);
                pointer = pointer.next;
                
                overflow = overflow / 10;
                
                l1 = l1?.next;
                l2 = l2?.next;
            }
            
            if (overflow != 0)
            {
                pointer.next = new ListNode(overflow);
            }
            return head.next;
        }
    }
}
