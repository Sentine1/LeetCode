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
            public bool FindTarget(TreeNode root, int k)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();

                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    TreeNode current = queue.Dequeue();

                    if (current.val != k - current.val && Helper(root, k - current.val))
                        return true;

                    if (current.left != null)
                        queue.Enqueue(current.left);

                    if (current.right != null)
                        queue.Enqueue(current.right);
                }

                return false;
            }

            private bool Helper(TreeNode root, int target)
            {
                if (root == null)
                    return false;

                if (root.val == target)
                    return true;
                if (root.val > target)
                    return Helper(root.left, target);
                else
                    return Helper(root.right, target);
            }
        }
    }
}