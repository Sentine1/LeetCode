using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Tasks21_30.Task23_Same_Tree.Solution();
            var treeP = new Tasks21_30.Task23_Same_Tree.TreeNode(
                1,new  Tasks21_30.Task23_Same_Tree.TreeNode(2)
                );
            var treeQ = new Tasks21_30.Task23_Same_Tree.TreeNode(
                1, null, new Tasks21_30.Task23_Same_Tree.TreeNode(2)
                );

            Assert.True(task.IsSameTree(treeP,treeQ), "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
