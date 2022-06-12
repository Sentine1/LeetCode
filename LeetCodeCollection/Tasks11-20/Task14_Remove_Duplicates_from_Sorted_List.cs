using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks11_20
{
    class Task14_Remove_Duplicates_from_Sorted_List
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
            public ListNode RemoveDuplicates(ListNode head)
            {
                var result = new ListNode();
                result.next = head;

                var current = result;

                while (current.next != null && current.next.next != null)
                    if (current.next.val == current.next.next.val)
                        current.next = current.next.next;
                    else
                        current = current.next;
                return result.next;
            }
        }
    }
}
