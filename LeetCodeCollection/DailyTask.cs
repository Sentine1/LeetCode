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
            public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
            {
                var prod = products.OrderBy(x => x);
                var result = new List<IList<string>>();
                var searchTemp = 0;
                foreach (var ch in searchWord)
                {
                    var find = new List<string>();
                    searchTemp++;
                    foreach (var word in prod)
                    {
                        if (word.StartsWith(searchWord.Substring(0,searchTemp)))
                            find.Add(word);
                        if (find.Count >= 3)
                            break;
                    }
                    result.Add(find);
                }
                return result;
            }
        }
    }
}