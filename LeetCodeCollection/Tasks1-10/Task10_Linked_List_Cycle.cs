using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks1_10
{
    class Task10_Linked_List_Cycle
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        public class Solution
        {
            public bool HasCycle(ListNode head)
            {
                if (head is null)
                    return false;
                var slow = head;
                var fast = head;

                while (fast.next is not null && fast.next.next is not null)
                {
                    fast = fast.next.next;
                    slow = slow.next;

                    if (fast == slow)
                        return true;
                }
                return false;
            }
        }
    }
}