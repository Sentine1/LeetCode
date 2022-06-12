using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks11_20
{
    class Task15_Reverse_Linked_List
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
            public ListNode ReverseList(ListNode head)
            {
                ListNode prev = new ListNode();
                var currentNode = head;
                while (currentNode is not null)
                {
                    var next = currentNode.next;
                    currentNode.next = prev;
                    prev = currentNode;
                    currentNode = next;
                }
                return prev;
            }
        }
    }
}

