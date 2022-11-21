using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public int NearestExit(char[][] maze, int[] entrance)
            {
                var queue = new Queue<(int[], int)>();
                queue.Enqueue((entrance, 0));
                var move = new[]{new []{-1,0}, new [] {0,-1},
                         new []{1, 0}, new [] {0, 1}
                        };

                var sizeX = maze[0].Count();
                var sizeY = maze.Count();

                while (queue.Count > 0)
                {
                    var tuple = queue.Dequeue();
                    var node = tuple.Item1;
                    var stepCount = tuple.Item2;
                    maze[node[0]][node[1]] = 'V';
                    Print(maze);

                    if (ExitCheck(node, sizeX, sizeY)
                       && stepCount > 0)
                        return stepCount;

                    

                    foreach (var step in move)
                    {
                        var x = node[0] + step[0];
                        var y = node[1] + step[1];
                        if ((x < sizeY && x > -1) &&                   
                            (y < sizeX && y > -1) &&                   
                            maze[x][y] == '.')
                        {
                            queue.Enqueue((new[] { x, y }, stepCount+1));
                        }
                    }
                }

                return -1;
            }
        

            public bool ExitCheck(int[] p, int sizeX, int sizeY)
            {
                return (p[1] == 0 || p[1] == sizeX - 1) ||
                    (p[0] == 0 || p[0] == sizeY - 1);
            }
            public static void Print(char[][] Maze)
            {
                Console.Clear();
                foreach (var item in Maze)
                {
                    foreach (var e in item)
                    {
                        Console.Write(e);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}