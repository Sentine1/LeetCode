﻿using System;
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


        public TreeNode BuildTree(int?[] nums, int i = 0, int j = 0)
        {
            var n = nums.Length;
            if (i > n - 1 || !nums[i].HasValue)
                return null;

            TreeNode node = new TreeNode(nums[i].Value);

            node.left = BuildTree(nums, 2 * i + 1, j );
            node.right = BuildTree(nums, 2 * i + 2, j);

            return node;
        }

        public override int GetHashCode()
        {
            int hash = 1117;
            int n = 0;
            var queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((left, n + 1));
            queue.Enqueue((right, n + 1));

            while (queue.Count > 0)
            {
                var tuple = queue.Dequeue();
                var node = tuple.Item1;
                n = tuple.Item2;
                if (node is null)
                    continue;

                hash = (33  * hash + node.GetHashCode() * n) % (int)1e9 + 7;

                if (node.left is not null)
                    queue.Enqueue((node.left, n + 1));
                else if (node.right is not null)
                    queue.Enqueue((node.right, n + 1));
            }
            return hash;
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }
    }
}
