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
            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
                if (root == null) return null;
                if (root == p || root == q) return root;

                var left = LowestCommonAncestor(root.left, p, q);
                var right = LowestCommonAncestor(root.right, p, q);

                if (left != null && right != null) return root;

                if (left != null) return left;
                if (right != null) return right;
                return null;
            }
        }
    }
}