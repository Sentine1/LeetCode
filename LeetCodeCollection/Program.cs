using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var daily = new DailyTask.Solution();
            var a = new DailyTask.TreeNode
                (0, new DailyTask.TreeNode(0, new DailyTask.TreeNode(0), new DailyTask.TreeNode(0)));
            var b = new DailyTask.TreeNode
               (0, new DailyTask.TreeNode(0, new DailyTask.TreeNode(0, new DailyTask.TreeNode(0, new DailyTask.TreeNode(0)))));
            Assert.True(daily.MinCameraCover(a) == 1, $"{daily.MinCameraCover(a)} is not {1}");
            Assert.True(daily.MinCameraCover(b) == 2, $"{daily.MinCameraCover(b)} is not {2}");
            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
