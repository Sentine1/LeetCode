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
            public int GoodNodes(TreeNode root)
            {
                if (root == null) { return 0; }

                int goodNodeCount = 0;
                Traverse(root, root.val, ref goodNodeCount);
                return goodNodeCount;
            }

            private void Traverse(TreeNode node, int maxPathValue, ref int goodNodeCount)
            {
                if (node == null) { return; }
                if (maxPathValue <= node.val) { maxPathValue = node.val; goodNodeCount++; }

                Traverse(node.left, maxPathValue, ref goodNodeCount);
                Traverse(node.right, maxPathValue, ref goodNodeCount);
            }
        }
    }
}
