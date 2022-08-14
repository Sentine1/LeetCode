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
            var inputA = new string[] { "hot", "dot", "dog", "lot", "log", "cog" };
            var inputB = new string[] { "hot", "dot", "dog", "lot", "log" };
            var outputA = new List<IList<string>>
                {
                new [] { "hit", "hot", "dot", "dog", "cog" } ,
                new []{ "hit", "hot", "lot", "log", "cog" }
                };

            var outputB = new string[] { };
            var tesst = task.FindLadders("hit", "cog", inputA);
            Assert.AreEqual(outputA, task.FindLadders("hit", "cog", inputA));
            Assert.AreEqual(outputB, task.FindLadders("hit", "cog", inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
