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

            var inputA = new int[][] {
                new []{7,0}, new []{4,4}, new []{7,1}, new []{5,0},
                new []{6,1}, new []{5,2}
            };

            var inputB = new int[][] {
                new []{6,0}, new []{5,0}, new []{4,0}, new []{3,2},
                new []{2,2}, new []{1,4}
        };
            var outputA = new int[][] {
                new []{5,0}, new []{7,0}, new []{5,2}, new []{6,1},
                new []{4,4}, new []{7,1}
            };
            var outputB = new int[][] {
                new []{4,0}, new []{5,0}, new []{2,2}, new []{3,2},
                new []{1,4}, new []{6,0}
        };
            var transformInputA = task.ReconstructQueue(inputA);
            var transformInputB = task.ReconstructQueue(inputB);

            Assert.AreEqual(transformInputA, outputA, "wrong answer");
            Assert.AreEqual(transformInputB, outputB, "wrong answer");

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
