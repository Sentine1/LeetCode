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

            ListNode before, after, i, j;

            public ListNode Partition(ListNode head, int x)
            {
                if (head == null) return head;
                ListNode temp = head;

                // Traversing all the nodes to make two separate lists
                while (temp != null)
                {
                    addNode(temp.val, temp.val < x);
                    temp = temp.next;
                }

                // Case if the list with smaller values has no items
                if (i == null) return after;

                // Else merge the lists
                else i.next = after;

                return before;
            }

            private void addNode(int val, bool isLess)
            {

                // Add node in smaller list (`before`)
                if (isLess)
                {

                    // Initialize the head of smaller list
                    if (before == null)
                    {
                        before = new ListNode(val);
                        i = before;
                    }

                    // Add node at the end of list and move pointer `i` to the last node
                    else
                    {
                        i.next = new ListNode(val);
                        i = i.next;
                    }
                }

                // Add node in greater list (`after`)
                else
                {

                    // Initialize the head of greater list
                    if (after == null)
                    {
                        after = new ListNode(val);
                        j = after;
                    }

                    // Add node at the end of list and move pointer `j` to the last node
                    else
                    {
                        j.next = new ListNode(val);
                        j = j.next;
                    }
                }
            }
        }
    }
}