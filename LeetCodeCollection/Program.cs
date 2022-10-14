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
            var inputA = new ListNode(1, 3, 4, 7, 1, 2, 6);
            var inputB = new ListNode(1, 2, 3, 4);
            var inputC = new ListNode(2, 1);
            var outputA = new ListNode(1, 3, 4, 1, 2, 6);
            var outputB = new ListNode(1, 2, 4);
            var outputC = new ListNode(2);

            Assert.AreEqual(outputA, task.DeleteMiddle(inputA));
            Assert.AreEqual(outputB, task.DeleteMiddle(inputB));
            Assert.AreEqual(outputC, task.DeleteMiddle(inputC));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
