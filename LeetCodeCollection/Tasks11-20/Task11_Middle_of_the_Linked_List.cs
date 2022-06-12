using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks11_20
{
    class Task11_Middle_of_the_Linked_List
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

        public class Solution
        {
            public ListNode MiddleNode(ListNode head)
            {
                var fast = head;
                var slow = head;
                while (fast.next is not null && fast.next.next is not null)
                {
                    fast = fast.next.next;
                    slow = slow.next;
                }

                return fast.next is not null ? slow.next : slow;
            }
        }
    }
}
