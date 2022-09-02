using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks21_30
{
    class Task26_Rotate_Image
    {
        public class Solution
        {
            public void Rotate(int[][] m)
            {
                ReverseTopToBottom(m);
                SwapBySymmetry(m);
            }

            private void ReverseTopToBottom(int[][] m)
            {
                int i = 0, j = m.Length - 1;

                while (i < j)
                {
                    int[] temp = m[i];
                    m[i] = m[j];
                    m[j] = temp;
                    i++;
                    j--;
                }
            }

            private void SwapBySymmetry(int[][] m)
            {
                for (int i = 0; i < m.Length; i++)
                {
                    for (int j = i + 1; j < m.Length; j++)
                    {
                        if (i != j)
                        {
                            int num = m[i][j];
                            m[i][j] = m[j][i];
                            m[j][i] = num;
                        }
                    }
                }
            }
        }
    }
}