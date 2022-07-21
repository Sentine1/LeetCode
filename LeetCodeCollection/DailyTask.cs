using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public ListNode ReverseBetween(ListNode head, int left, int right)
            {
                if (head == null || head.next == null)
                    return head;

                ListNode d = new ListNode(),
                         cur = d,
                         n1 = head,
                         n2 = null,
                         n3 = null,
                         n4 = null;
                int i = 1;

                d.next = head;

                while (i < left)
                {
                    cur = cur.next;
                    n1 = n1.next;

                    i++;
                }

                cur.next = null;
                n4 = n1;

                i = 0;

                n2 = n1.next;
                if (n2 != null)
                    n3 = n2.next;

                while (i < (right - left) && n2 != null)
                {
                    n2.next = n1;

                    n1 = n2;
                    n2 = n3;

                    if (n2 != null)
                        n3 = n2.next;

                    i++;
                }

                cur.next = n1;
                n4.next = n2;

                return d.next;
            }
        }
    }
}