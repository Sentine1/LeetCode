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

            var inputA = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5, new ListNode(2))))));
            var inputB = new ListNode(2, new ListNode(1));
            var outputA = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(4, new ListNode(3, new ListNode(5))))));
            var outputB = new ListNode(1, new ListNode(2));
            //var test = new ListNode(5,6,7,8,9,0); Inprogress

            Assert.AreEqual(outputA, task.Partition(inputA, 3));
            Assert.AreEqual(outputB, task.Partition(inputB, 2));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
