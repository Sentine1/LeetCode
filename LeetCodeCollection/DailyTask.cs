using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public int MaxAncestorDiff(TreeNode root)
            {
                (int min, int max, int diff) f(TreeNode n)
                {
                    int val = n.val, min = val, max = val, diff = 0;
                    if (n.left != null)
                    {
                        var l = f(n.left);
                        min = Math.Min(min, l.min);
                        max = Math.Max(max, l.max);
                        diff = Math.Max(diff, l.diff);
                    }
                    if (n.right != null)
                    {
                        var r = f(n.right);
                        min = Math.Min(min, r.min);
                        max = Math.Max(max, r.max);
                        diff = Math.Max(diff, r.diff);
                    }
                    diff = Math.Max(diff, Math.Abs(val - min));
                    diff = Math.Max(diff, Math.Abs(val - max));
                    return (min, max, diff);
                }
                return f(root).diff;
            }
        }
    }
}