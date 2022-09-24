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
            public IList<IList<int>> PathSum(TreeNode root, int sum)
            {
                var result = new List<IList<int>>();
                DFS(root, sum, new List<int>(), result);
                return result;
            }

            private void DFS(TreeNode root, int sum, IList<int> oneResult, IList<IList<int>> result)
            {
                if (root == null) return;
                oneResult.Add(root.val);
                if (root.left == null && root.right == null)
                {
                    if (sum == root.val)
                    {
                        result.Add(new List<int>(oneResult));
                    }
                }
                else
                {
                    DFS(root.left, sum - root.val, oneResult, result);
                    DFS(root.right, sum - root.val, oneResult, result);
                }
                oneResult.RemoveAt(oneResult.Count - 1);
            }
        }
    }
}