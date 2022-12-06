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
            var InputA = new ListNode(1, 2, 3, 4, 5);
            var InputB = new ListNode(2, 1, 3, 5, 6, 4, 7);
            var OutputA = new ListNode(1, 3, 5, 2, 4);
            var OutputB = new ListNode(2, 3, 6, 7, 1, 5, 4);


            Assert.True(OutputA.GetHashCode() == task.OddEvenList(InputA).GetHashCode());
            Assert.AreEqual(OutputA, task.OddEvenList(InputA));
            Assert.AreEqual(OutputB, task.OddEvenList(InputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
