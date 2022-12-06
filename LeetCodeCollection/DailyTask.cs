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
            public ListNode OddEvenList(ListNode head)
            {
                if (head is null)
                    return null;
                if (head.next is null)
                    return head;
                ListNode oddStart = new ListNode(-9);
                ListNode evenStart = new ListNode(-6);
                ListNode odd = oddStart;
                ListNode even = evenStart;
                var node = head;
                while (node is not null)
                {
                    odd.next = new ListNode(node.val);
                    if (node.next is not null)
                        even.next = new ListNode(node.next.val);
                    odd = odd.next;
                    if (even is not null)
                        even = even.next;
                    if (node.next is null || node.next.next is null)
                    {
                        odd.next = evenStart.next;
                        break;
                    }
                    node = node.next.next;
                }

                return oddStart.next;
            }
        }
    }
}