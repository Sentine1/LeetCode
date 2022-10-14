using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public ListNode DeleteMiddle(ListNode head)
            {
                if (head == null || head.next == null) return null;

                var fast = head.next.next;
                var slow = head;

                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }
                slow.next = slow.next.next;
                return head;
            }
        }
    }
}