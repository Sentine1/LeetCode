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
                
                if (queue is null && element is not null)
                {
                    this.val = element.Value;
                    queue.Enqueue(null);
                    queue.Enqueue(null);
                    continue;
                }

                var node = queue.Dequeue();
                if (node.left is null)
                {
                    this.left = new TreeNode(element);
                    continue;
                }

                if (node.right is null)
                {
                    this.right = new TreeNode(element);
                    continue;
                }

                throw new Exception($"Element {element} not using");
            }
        }
    }
}
