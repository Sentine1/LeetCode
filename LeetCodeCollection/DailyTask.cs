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
            public IList<IList<int>> LevelOrder(TreeNode root)
            {
                var res = new List<List<int>>();
                if (root == null)
                    return res.Cast<IList<int>>().ToList();
                var q = new Queue<Tuple<TreeNode, int>>();
                q.Enqueue(new(root, 1));
                var level = 1;
                res.Add(new());
                while (q.Count > 0)
                {
                    var node = q.Dequeue();
                    if (level == node.Item2)
                    {
                        res[level - 1].Add(node.Item1.val);
                    }
                    else
                    {
                        level++;
                        res.Add(new() { node.Item1.val });
                    }
                    if (node.Item1.left != null)
                        q.Enqueue(new(node.Item1.left, node.Item2 + 1));
                    if (node.Item1.right != null)
                        q.Enqueue(new(node.Item1.right, node.Item2 + 1));
                }
                return res.Cast<IList<int>>().ToList();
            }
        }
    }
}