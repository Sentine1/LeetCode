using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
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
        public ListNode(params int[] input)
        {
            ListNode listNode;
            ListNode progres = new ListNode();
            listNode = progres;
            foreach (var element in input)
            {
                progres.next = new ListNode(element);
                progres = progres.next;
            }
            this.val = listNode.next.val;
            this.next = listNode.next.next;
        }

        public override bool Equals(object obj)
        {

            return this.val == ((ListNode)obj).val;
        }
    }
}
