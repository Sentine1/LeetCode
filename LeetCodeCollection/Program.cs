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
            var inputA = new[] { 3, 2, 1, 5, 6, 4 };
            var inputB = new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            
            var outputA = daily.FindKthLargest(inputA, 2);
            var outputB = daily.FindKthLargest(inputB, 4);

            Assert.True(outputA == 5, $"{outputA} is not 5");
            Assert.True(outputB == 4, $"{outputB} is not 4");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
