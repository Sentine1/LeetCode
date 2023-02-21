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
            var InputA = new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            var InputB = new int[] { 3, 3, 7, 7, 10, 11, 11 };


            Assert.AreEqual(2, task.SingleNonDuplicate(InputA));
            Assert.AreEqual(10, task.SingleNonDuplicate(InputB));


            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
