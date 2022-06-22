using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Tasks21_30.Task24_Path_Sum.Solution();
            var treeA = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))),
                new TreeNode(8, new TreeNode(13), new TreeNode(4,null, new TreeNode(1))));
            var treeB = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            var treeC = treeB.left.left;

            Assert.True(task.HasPathSum(treeA, 22), "wrong answer");
            Assert.True(task.HasPathSum(treeB, 5) == false, "wrong answer");
            Assert.True(task.HasPathSum(treeC, 0) == false, "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey()
                ;
        }
    }
}
