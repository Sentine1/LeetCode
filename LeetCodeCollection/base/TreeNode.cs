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
            foreach (var element in input)
            {
                Add(element);
            }
        }

        public void Add(int? newValue)
        {
            if (newValue.HasValue) 
                val = newValue.Value;
            
            else if (newValue.Value > 0)
            {
                if (right == null) right = new TreeNode ( newValue );
                else right.Add(newValue);
            }

            else
            {
                if (left == null) left = new TreeNode(newValue);
                else left.Add(newValue);
            };
        }
    }
}
