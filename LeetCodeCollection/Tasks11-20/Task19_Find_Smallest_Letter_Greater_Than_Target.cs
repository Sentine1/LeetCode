using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection.Tasks11_20
{
    class Task19_Find_Smallest_Letter_Greater_Than_Target
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            var right = letters.Length - 1;
            var left = 0;
            while (left <= right)
            {
                var middle = left + (right - left) / 2;
                if (letters[middle] > target)
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return letters[left % letters.Length];
        }
    }
}
