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
            public string IntToRoman(int num)
            {
                /*
                 * I = 1
                 * V = 5
                 * X = 10
                 * L = 50
                 * C = 100
                 * D = 500
                 * M = 1000
                 */
                var answer = new StringBuilder();

                while (num > -1)
                {
                    if (num >= 1000)
                    {
                        answer.Append("M");
                        num -= 1000;
                    }

                    else if (num >= 900)
                    {
                        answer.Append("CM");
                        num -= 900;
                    }

                    else if (num >= 500)
                    {
                        answer.Append("D");
                        num -= 500;
                    }

                    else if (num >= 400)
                    {
                        answer.Append("CD");
                        num -= 400;
                    }

                    else if (num >= 100)
                    {
                        answer.Append("C");
                        num -= 100;
                    }

                    else if (num >= 90)
                    {
                        answer.Append("XC");
                        num -= 90;
                    }

                    else if (num >= 50)
                    {
                        answer.Append("L");
                        num -= 50;
                    }

                    else if (num >= 40)
                    {
                        answer.Append("XL");
                        num -= 40;
                    }

                    else if (num >= 10)
                    {
                        answer.Append("X");
                        num -= 10;
                    }

                    else if (num >= 9)
                    {
                        answer.Append("IX");
                        num -= 9;
                    }

                    else if (num >= 5)
                    {
                        answer.Append("V");
                        num -= 5;
                    }

                    else if (num >= 4)
                    {
                        answer.Append("IV");
                        num -= 4;
                    }

                    else if (num >= 1)
                    {
                        answer.Append("I");
                        num -= 1;
                    }
                    else num = -1;
                }

                return answer.ToString();
            }
        }
    }
}