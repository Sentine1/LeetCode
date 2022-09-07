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
            private StringBuilder res = new StringBuilder();

            public string Tree2str(TreeNode t)
            {
                res = new StringBuilder();
                if (t == null)
                    return string.Empty;

                DFS(t, true);

                return res.ToString();
            }

            private void DFS(TreeNode node, bool isRoot = false)
            {
                if (!isRoot)
                    res.Append("(");

                res.Append(node.val);

                if (node.left == null && node.right != null)
                    res.Append("()");
                else if (node.left != null)
                    DFS(node.left);

                if (node.right != null)
                    DFS(node.right);

                if (!isRoot)
                    res.Append(")");
            }
        }
    }
}
