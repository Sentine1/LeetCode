using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode(params int?[] input) // In progress;
        {
            var queue = new Queue<TreeNode>();
            foreach (var element in input)
            {
                
                if (queue is null)
                {
                    new TreeNode(element);
                    queue.Enqueue(left);
                    queue.Enqueue(right);
                    continue;
                }
                var node = queue.Dequeue();
                if (node.left is null)
                {
                    new TreeNode(element);
                    queue.Enqueue(left);
                    queue.Enqueue(right);
                    continue;
                }
                if (node.right is null)
                {
                    new TreeNode(element);
                    queue.Enqueue(left);
                    queue.Enqueue(right);
                    continue;
                }

            }
        }
    }
}
