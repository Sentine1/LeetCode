using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks11_20
{
    class Task13_Remove_Linked_List_Elements
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
            public ListNode RemoveElements(ListNode head, int val)
            {
                var result = new ListNode();
                result.next = head;

                var current = result;

                while (current.next != null)
                    if (current.next.val == val)
                        current.next = current.next.next;
                    else
                        current = current.next;
                return result.next;
            }
        }
    }
}
