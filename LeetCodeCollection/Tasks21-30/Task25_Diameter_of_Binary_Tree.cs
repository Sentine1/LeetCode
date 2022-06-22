using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks21_30
{
    class Task25_Diameter_of_Binary_Tree
    {
        public class Solution
        {
            public int DiameterOfBinaryTree(TreeNode root)
            {
                int d = 0;
                DiametrLongestPatch(root, d);
                return d;
            }

            public int DiametrLongestPatch(TreeNode node, ref int d)
            {
                if (node is null)
                    return 0;
                var left = DiametrLongestPatch(node.left, ref d);
                var right = DiametrLongestPatch(node.right, ref d);
                d = Math.Max(d, left + right);
                return Math.Max(left, right + 1);
            }
        }
    }
}