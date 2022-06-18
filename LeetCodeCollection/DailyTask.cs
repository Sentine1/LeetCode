using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCollection
{
    public class DailyTask
    {
        public class WordFilter
        {

            public class TrieNode
            {
                public TrieNode[] links = new TrieNode[27];
                public int index;
            }

            public class Trie
            {
                internal TrieNode root;

                public Trie()
                {
                    root = new TrieNode();
                }

                internal void insert(string word, int id)
                {
                    TrieNode node = root;

                    foreach(char ch in word)
                    {
                        if (node.links[ch - 'a'] == null)
                            node.links[ch - 'a'] = new TrieNode();

                        node = node.links[ch - 'a'];
                        node.index = id;
                    }
                }

                internal int index(string word)
                {
                    TrieNode node = root;
                    foreach (char ch in word)
                    {
                        if (node.links[ch - 'a'] == null)
                            return -1;

                        node = node.links[ch - 'a'];
                    }
                    return node.index;
                }
            }

            Trie trie = new Trie();

            public WordFilter(string[] words)
            {
                int index = 0;
                foreach(var w in words.Select(x=>x.ToLower()))
                {
                    string st = "";
                    for (int i = w.Length - 1; i >= 0; i--)
                    {
                        st = w[i] + st;
                        string inp = st + "{" + w;
                        trie.insert(inp, index);
                    }

                    index++;
                }
            }

            public int f(string prefix, string suffix)
            {
                string st = suffix + "{" + prefix;
                return trie.index(st);
            }
        }
    }
}