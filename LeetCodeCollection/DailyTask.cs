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
            public int CountNodes(TreeNode root)
            {
                if (root == null)
                    return 0;
                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                var nodeCount = 0;
                while (queue.Count > 0)
                {
                    var node = queue.Dequeue();
                    nodeCount++;
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                return nodeCount;
            }
        }
    }
}