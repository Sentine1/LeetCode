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
            for (int i = 0; i < input.Length; i++)
            {
                queue.Enqueue(new TreeNode(input[i].Value));
            }
            var full = new TreeNode();
            if (queue.Count != 0)
            {
                full = addValues(queue);
                this.val = full.val;
            }
            if (queue.Count > 1)
                this.left = full.left;
            if (queue.Count > 2)
                this.right = full.right;
        }

        public TreeNode addValues (Queue<TreeNode> input)
        {
            var queue = input;
            if (queue.Count == 0)
                return null;
            var node = new TreeNode(); 
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                if (queue.Count > 1)
                    node.left = addValues(queue);
                if (queue.Count > 1)
                    node.right = addValues(queue);
            }
            return node;
        }
    }
}
