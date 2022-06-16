using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks21_30
{
    public class Task22_Minimum_Depth_of_Binary_Tree
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            public int MinDepth(TreeNode root)
            {
                if (root is null)
                    return 0;
                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                var depth = 1;

                while (queue.Count > 0)
                {
                    var n = queue.Count;

                    for (int i = 0; i < n; i++)
                    {
                        var node = queue.Dequeue();
                        if (node.left == null && node.right == null)
                            return depth;
                        if (node.left != null)
                            queue.Enqueue(node.left);
                        if (node.right != null)
                            queue.Enqueue(node.right);
                    }

                    depth++;
                }
                return depth;
            }
        }
    }
}
