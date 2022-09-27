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
            var inputA = "RR.L";
            var inputB = ".L.R...LR..L..";
            
            var outputA = "RR.L";
            var outputB = "LL.RR.LLRRLL..";

            Assert.AreEqual(outputA, task.PushDominoes(inputA));
            Assert.AreEqual(outputB, task.PushDominoes(inputB));


            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
