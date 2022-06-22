using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks21_30
{
    public class Task23_Same_Tree
    {
        public class Solution
        {
            public bool IsSameTree(TreeNode p, TreeNode q)
            {
                if (p == null && q != null || p != null && q == null)
                    return false;
                var queue = new Queue<(TreeNode,TreeNode)>();
                queue.Enqueue((p,q));

                while (queue.Count > 0)
                {
                    (p, q) = queue.Dequeue();
                    if (p == null && q == null)
                        continue;
                    if (p == null || q == null)
                        return false;
                    if (p.val != q.val)
                        return false;

                    queue.Enqueue((p.left,q.left));
                    queue.Enqueue((p.right, q.right));
                }
                return true;
            }
        }
    }
}
