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


        public TreeNode BuildTree(int i, int j, params int?[] nums)
        {
            var n = nums.Length;
            if (i > n - 1 || !nums[i].HasValue)
                return null;

            TreeNode node = new TreeNode(nums[i].Value);

            node.left = BuildTree(2*i+1, j, nums);
            node.right = BuildTree(2*i+2, j, nums);

            return node;
        }

        public override int GetHashCode()
        {
            int hash = 5381;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(left);
            queue.Enqueue(right);
            int n = 0;
            while (queue.Count > 0)
            {
                n++;
                var node = queue.Dequeue();
                if (node is null)
                    continue;
                
                hash = 33 * hash + node.GetHashCode() + n % (int)1e9+7;
                
                    if (node.left is not null)
                        queue.Enqueue(node.left);
                    else if (node.right is not null)
                        queue.Enqueue(node.right);
            }
            return hash;
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }
    }
}
