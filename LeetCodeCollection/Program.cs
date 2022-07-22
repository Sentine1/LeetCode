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

            var inputA = new ListNode(1, 4, 3, 2, 5, 2);
            var inputB = new ListNode(2, 1);
            var outputA = new ListNode(1, 2, 2, 4, 3, 5);
            var outputB = new ListNode(1, 2);

            Assert.AreEqual(outputA, task.Partition(inputA, 3));
            Assert.AreEqual(outputB, task.Partition(inputB, 2));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
