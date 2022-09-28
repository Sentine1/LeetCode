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
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                if (head == null)
                    return null;

                ListNode answer = new ListNode(-1);
                var tempNode1 = answer;
                var tempNode2 = answer;
                tempNode1.next = head;

                for (int i = 1; i <= n + 1; i++)
                    tempNode2 = tempNode2.next;

                while (tempNode2 != null)
                {
                    tempNode1 = tempNode1.next;
                    tempNode2 = tempNode2.next;
                }

                tempNode1.next = tempNode1.next.next;

                return answer.next;
            }
        }
    }
}