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
            public bool IsValidBST(TreeNode root)
            {
                var queue = new Queue<(TreeNode, long, long)>();
                queue.Enqueue((root,long.MinValue, long.MaxValue));

                while(queue.Count > 0)
                {
                    var tuple = queue.Dequeue();
                    var node = tuple.Item1;

                    if (node == null)
                        continue;

                    var min = tuple.Item2;
                    var max = tuple.Item3;

                    if (node.val <= min || node.val >= max)
                        return false;

                    if (node.left is not null)
                    {
                        queue.Enqueue((node.left,min,node.val));
                    }
                    if (node.right is not null)
                    {
                        queue.Enqueue((node.right,node.val,max));
                    }
                }

                return true;
            }
        }
    }
}
