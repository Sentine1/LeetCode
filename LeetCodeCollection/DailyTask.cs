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
            public IList<int> InorderTraversal(TreeNode root)
            {
                return BST(root);
            }

            private List<int> BST(TreeNode node)
            {
                var result = new List<int>();
                var stack = new Stack<TreeNode>();
                var cur = node;

                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }

                while (stack.Any())
                {
                    cur = stack.Pop();
                    result.Add(cur.val);

                    if (cur.right != null)
                    {
                        cur = cur.right;

                        while (cur != null)
                        {
                            stack.Push(cur);
                            cur = cur.left;
                        }
                    }
                }

                return result;
            }
        }
    }
}
