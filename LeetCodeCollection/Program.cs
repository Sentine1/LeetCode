using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LeetCodeCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new DailyTask.Solution();
            var defTree = new TreeNode();

            Assert.AreEqual(false, task.IsUgly(97));
            Assert.AreEqual(true, task.IsUgly(6));
            Assert.AreEqual(true, task.IsUgly(1));
            Assert.AreEqual(false, task.IsUgly(14));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
