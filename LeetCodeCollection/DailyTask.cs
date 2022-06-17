using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
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
            int res;
            public int MinCameraCover(TreeNode root)
            {
                res = 0;
                return (dfs(root) < 1 ? 1 : 0) + res;
            }

            public int dfs(TreeNode root)
            {
                if (root == null)
                {
                    return 2;
                }
                int left = dfs(root.left), right = dfs(root.right);
                if (left == 0 || right == 0)
                {
                    res++;
                    return 1;
                }
                return left == 1 || right == 1 ? 2 : 0;
            }
        }
    }
}