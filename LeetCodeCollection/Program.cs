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
            var inputA = new[]{
                new[]{'5','3','.','.','7','.','.','.','.'}
                ,new[]{'6','.','.','1','9','5','.','.','.'}
                ,new[]{'.','9','8','.','.','.','.','6','.'}
                ,new[]{'8','.','.','.','6','.','.','.','3'}
                ,new[]{'4','.','.','8','.','3','.','.','1'}
                ,new[]{'7','.','.','.','2','.','.','.','6'}
                ,new[]{'.','6','.','.','.','.','2','8','.'}
                ,new[]{'.','.','.','4','1','9','.','.','5'}
                ,new[]{'.','.','.','.','8','.','.','7','9'}};
            var inputB = new[]{
                new[]{'8','3','.','.','7','.','.','.','.'}
                ,new[]{'6','.','.','1','9','5','.','.','.'}
                ,new[]{'.','9','8','.','.','.','.','6','.'}
                ,new[]{'8','.','.','.','6','.','.','.','3'}
                ,new[]{'4','.','.','8','.','3','.','.','1'}
                ,new[]{'7','.','.','.','2','.','.','.','6'}
                ,new[]{'.','6','.','.','.','.','2','8','.'}
                ,new[]{'.','.','.','4','1','9','.','.','5'}
                ,new[]{'.','.','.','.','8','.','.','7','9'}};

            Assert.AreEqual(true, task.IsValidSudoku(inputA));
            Assert.AreEqual(false, task.IsValidSudoku(inputB));

            Console.WriteLine("Test complite");
            Console.ReadKey();
        }
    }
}
