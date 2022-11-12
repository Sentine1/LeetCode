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
            var task2 = new DailyTask.MedianFinder();
            task2.AddNum(6);
            Assert.AreEqual(6, task2.FindMedian());
            task2.AddNum(10);
            Assert.AreEqual(8, task2.FindMedian());
            task2.AddNum(2);
            Assert.AreEqual(6, task2.FindMedian());
            task2.AddNum(6);
            Assert.AreEqual(6, task2.FindMedian());
            task2.AddNum(5);
            Assert.AreEqual(6, task2.FindMedian());
            task2.AddNum(0);
            Assert.AreEqual(5.5, task2.FindMedian());
            task2.AddNum(6);
            Assert.AreEqual(6, task2.FindMedian());
            task2.AddNum(3);
            Assert.AreEqual(5.5, task2.FindMedian());
            task2.AddNum(1);
            Assert.AreEqual(5, task2.FindMedian());
            task2.AddNum(0);
            Assert.AreEqual(4, task2.FindMedian());
            task2.AddNum(0);
            Assert.AreEqual(3, task2.FindMedian());

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
