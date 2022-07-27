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
            public void Flatten(TreeNode root)
            {
                if (root == null)
                    return;

                DFS(root);
            }

            private TreeNode DFS(TreeNode node)
            {
                if (node.left == null && node.right == null)
                    return node;

                TreeNode l = node.left == null ? null : DFS(node.left),
                         r = node.right == null ? null : DFS(node.right);

                if (l != null && r != null)
                {
                    l.right = node.right;
                    node.right = node.left;
                    node.left = null;

                    return r;
                }
                else if (l != null)
                {
                    node.right = node.left;
                    node.left = null;

                    return l;
                }
                else
                    return r;
            }
        }
    }
}