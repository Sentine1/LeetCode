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
            public IList<int> RightSideView(TreeNode root)
            {
                if (root == null)
                    return new List<int>();

                List<int> result = new List<int>();
                Queue<TreeNode> queue = new Queue<TreeNode>();

                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    int count = queue.Count;

                    while (count > 0)
                    {
                        TreeNode currentNode = queue.Dequeue();

                        if (count == 1)
                            result.Add(currentNode.val);

                        if (currentNode.left != null)
                            queue.Enqueue(currentNode.left);

                        if (currentNode.right != null)
                            queue.Enqueue(currentNode.right);

                        count--;
                    }
                }

                return result;
            }
        }
    }
}