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
            int count;
            public int PseudoPalindromicPaths(TreeNode root)
            {
                count = 0;
                HashSet<int> set = new HashSet<int>();
                DFS(root, set);
                return count;

            }

            private void DFS(TreeNode node, HashSet<int> set)
            {

                if (node == null) return;

                if (set.Contains(node.val)) set.Remove(node.val);
                else set.Add(node.val);

                if (node.left == null && node.right == null)
                {
                    if (set.Count() <= 1)
                        count++;
                    return;
                }

                if (node.left != null) DFS(node.left, new HashSet<int>(set));

                if (node.right != null) DFS(node.right, new HashSet<int>(set));

                return;
            }
        }
    }
}