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
            public int[][] DiagonalSort(int[][] mat)
            {
                var rowCount = mat.Length;
                var columCount = mat[0].Length;

                if (rowCount == 0 || columCount == 0)
                {
                    return null;
                }
                int i, j, r, c, ind;

                r = 0;
                c = columCount - 1;
                while (r != rowCount)
                {
                    List<int> diagArray = new List<int>();
                    i = r;
                    j = c;
                    while (i < rowCount && j < columCount)
                    {
                        diagArray.Add(mat[i][j]);
                        i++;
                        j++;
                    }
                    diagArray.Sort();

                    i = r;
                    j = c;
                    ind = 0;
                    while (i < rowCount && j < columCount)
                    {
                        mat[i][j] = diagArray[ind];
                        i++;
                        j++;
                        ind++;
                    }
                    if (c > 0)
                    {
                        c--;
                    }
                    else
                    {
                        r++;
                    }
                }
                return mat;
            }
        }
    }
}
