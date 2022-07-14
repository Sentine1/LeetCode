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
            public TreeNode BuildTree(int[] preorder, int[] inorder)
            {
                if (preorder == null || preorder.Length == 0 || inorder == null || inorder.Length == 0)
                    return null;

                return BuildTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
            }

            private TreeNode BuildTree(int[] preorder, int i, int j, int[] inorder, int k, int l)
            {
                if (i > j || k > l)
                    return null;

                TreeNode node = new TreeNode(preorder[i]);

                if (i != j)
                {
                    int m = k;

                    for (; m < inorder.Length; m++)
                        if (inorder[m] == preorder[i])
                            break;

                    node.left = BuildTree(preorder, i + 1, i + m - k, inorder, k, m - 1);
                    node.right = BuildTree(preorder, i + 1 + m - k, j, inorder, m + 1, l);
                }

                return node;
            }
        }
    }
}