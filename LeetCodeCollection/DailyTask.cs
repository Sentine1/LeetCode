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
            public TreeNode SortedArrayToBST(int[] nums)
            {
                if (nums == null || nums.Length == 0)
                    return null;

                return BuildTree(nums, 0, nums.Length - 1);
            }

            private TreeNode BuildTree(int[] nums, int i, int j)
            {
                if (j < i)
                    return null;

                int mid = j + (i - j) / 2;
                TreeNode node = new TreeNode(nums[mid]);

                node.left = BuildTree(nums, i, mid - 1);
                node.right = BuildTree(nums, mid + 1, j);

                return node;
            }
        }
    }
}
