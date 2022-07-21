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

            var inputA = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var inputB = new ListNode(5);
            var outputA = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5)))));
            var outputB = new ListNode(5);

            Assert.AreEqual(outputA, task.ReverseBetween(inputA, 2, 4));
            Assert.AreEqual(outputB, task.ReverseBetween(inputB, 1, 1));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
