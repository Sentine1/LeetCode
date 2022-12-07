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
            public int RangeSumBST(TreeNode root, int low, int high)
            {
                long count = 0; ;
                var nodes = new Queue<TreeNode>();
                nodes.Enqueue(root);
                while(nodes.Count > 0 )
                {
                    var node = nodes.Dequeue();
                    if (Check(low, high, node))
                    {
                        count +=node.val;
                    }
                    if (node.left is not null )
                        nodes.Enqueue(node.left);
                    if (node.right is not null )
                        nodes.Enqueue(node.right);
                }
                return (int)count;
            }

            private static bool Check(int low, int high, TreeNode node)
            {
                return node.val >= low && node.val <= high;
            }
        }
    }
}