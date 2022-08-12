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
            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
                var answer = root;
                var min = p;
                var max = q;
                if (min.val > max.val)
                {
                    var temp = max;
                    max = min;
                    min = temp;
                }
                while(true)
                {
                    var node = answer;
                    if (min.val <= node.val && max.val >= node.val || min == answer || max == answer)
                        break;
                    if (max.val < node.val && node.left is not null)
                    answer = node.left;
                    else if (min.val > node.val && node.right is not null)
                    answer = node.right;
                    else return answer;
                }
                return answer;
            }
        }
    }
}
