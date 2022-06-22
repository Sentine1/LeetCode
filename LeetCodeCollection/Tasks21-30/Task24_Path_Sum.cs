using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks21_30
{
    class Task24_Path_Sum
    {
        public class Solution
        {
            public bool HasPathSum(TreeNode node, int target)
            {
                if (node is null)
                    return false;
                target -= node.val;
                if (node.left is null && node.right is null)
                    return target == 0;
                return HasPathSum(node.left, target) ||  HasPathSum(node.right, target);
            }
        }
    }
}
