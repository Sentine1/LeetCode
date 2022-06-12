using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks11_20
{
    class Task16_Merge_Two_Sorted_Lists
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
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                var result = new ListNode();
                var merged = result;
                while (list1 is not null && list2 is not null)
                {
                    if (list1.val < list2.val)
                    {
                        merged.next = list1;
                        merged = merged.next;
                        list1 = list1.next;
                    }
                    else
                    {
                        merged.next = list2;
                        merged = merged.next;
                        list2 = list2.next;
                    }
                }
                merged.next = list1 != null ? list1 : list2;
                return result.next;
            }
        }
    }
}
