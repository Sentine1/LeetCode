using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class Solution
        {
            public IList<IList<int>> Generate(int numRows)
            {
                IList<IList<int>> answer = new List<IList<int>>() { new List<int>() { 1 } };

                for (int i = 2; i <= numRows; i++)
                {
                    List<int> line = new List<int>() { 1 };

                    for (int j = 1; j < i - 1; j++)
                        line.Add(answer[i - 2][j - 1] + answer[i - 2][j]);

                    line.Add(1);

                    answer.Add(line);
                }

                return answer;
            }
        }
    }
}