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
                var queue = new Queue<(int,int, int)>();
                queue.Enqueue((entrance[0],entrance[1], 0));
                var move = new[]{new []{-1,0}, new [] {0,-1},
                         new []{1, 0}, new [] {0, 1}
                        };
                var visited = new HashSet<(int, int)>();
                var sizeX = maze.Count();
                var sizeY = maze[0].Count();

                while (queue.Count > 0)
                {
                    var tuple = queue.Dequeue();
                    var nodeX = tuple.Item1;
                    var nodeY = tuple.Item2;
                    var stepCount = tuple.Item3;

                    //maze[nodeX][nodeY] = 'V';
                    //Print(maze);

                    if (ExitCheck(nodeX, nodeY, sizeX, sizeY)
                       && stepCount > 0)
                        return stepCount;

                    visited.Add((nodeX, nodeY));

                    foreach (var step in move)
                    {
                        var x = nodeX + step[0];
                        var y = nodeY + step[1];
                        if (x < sizeX && x > -1 &&
                            y < sizeY && y > -1 &&
                            maze[x][y] == '.' && !visited.Contains((x,y)))
                        {
                            queue.Enqueue((x, y, stepCount+1));
                        }
                    }
                }

                return -1;
            }
        

            public bool ExitCheck(int x, int y, int sizeX, int sizeY)
            {
                return y == 0 || y == sizeY - 1 ||
                    x == 0 || x == sizeX - 1;
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