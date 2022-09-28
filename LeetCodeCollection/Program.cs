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
            var inputA = new ListNode(1, 2, 3, 4, 5);
            var inputB = new ListNode(1);
            var inputC = new ListNode(1, 2);
            var inputD = new ListNode(1, 2, 3);

            var outputA = new ListNode(1, 2, 3, 5);
            var outputB = new ListNode().next;
            var outputC = new ListNode(1);
            var outputD = new ListNode(2,3);

            Assert.AreEqual(outputA, task.RemoveNthFromEnd(inputA, 2));
            Assert.AreEqual(outputB, task.RemoveNthFromEnd(inputB, 1));
            Assert.AreEqual(outputC, task.RemoveNthFromEnd(inputC, 1));
            Assert.AreEqual(outputD, task.RemoveNthFromEnd(inputD, 3));


            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
