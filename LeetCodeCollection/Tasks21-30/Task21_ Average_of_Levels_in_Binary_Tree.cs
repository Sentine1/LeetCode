﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks21_30
{
    public class Task21__Average_of_Levels_in_Binary_Tree
    {
        public class Solution
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
            }

            public IList<double> AverageOfLevels(TreeNode root)
            {
                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                var midPerLevel = new List<double>();

                while (queue.Count > 0)
                {
                    var n = queue.Count;
                    var summ = 0.0;

                    for (int i = 0; i < n; i++)
                    {
                        var node = queue.Dequeue();
                        summ += node.val;
                        if (node.left != null)
                            queue.Enqueue(node.left);
                        if (node.right != null)
                            queue.Enqueue(node.right);
                    }
                    midPerLevel.Add(summ / n);
                }
                return midPerLevel;
            }
        }
    }
}