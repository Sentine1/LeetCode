using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
            {
                var queue = new Queue<(TreeNode, int)>();
                var answer = new List<IList<int>>();
                if (root is null)
                    return answer;
                queue.Enqueue((root, 1));
                while (queue.Count > 0)
                {
                    var tuple = queue.Dequeue();
                    var node = tuple.Item1;
                    var level = tuple.Item2;
                    if (node is null)
                        continue;
                    if (answer.Count >= level)
                        answer[level - 1].Add(node.val);
                    else answer.Add(new List<int>() { node.val });

                    if (node.left is not null)
                        queue.Enqueue((node.left, level + 1));
                    if (node.right is not null)
                        queue.Enqueue((node.right, level + 1));
                }
                for (int i = 0; i < answer.Count; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        answer[i] = answer[i].Reverse().ToList();
                    }
                }
                return answer;
            }
        }
    }
}