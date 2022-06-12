using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks11_20
{
    class Task12_Palindrome_Linked_List
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
            public bool IsPalindrome(ListNode head)
            {
                if (head is null)
                    return false;

                var middle = MiddleNode(head);
                var reverce = ReverseList(middle);
                while (reverce is not null)
                {
                    if (reverce.val != head.val)
                        return false;
                    reverce = reverce.next;
                    head = head.next;
                }
                return true;

                ListNode MiddleNode(ListNode head)
                {
                    var fast = head;
                    var slow = head;

                    while (fast.next is not null && fast.next.next is not null)
                    {
                        fast = fast.next.next;
                        slow = slow.next;
                    }

                    return fast.next is null ? slow : slow.next;
                }

                ListNode ReverseList(ListNode head)
                {
                    ListNode prev = null;
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
}
