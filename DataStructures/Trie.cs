using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures
{
    class TrieNode {
        public char Letter { get; set; }
        public int WordsInSubtree { get; set; }
        public bool IsEndOfWord { get; set; }
        public Dictionary<char, TrieNode> Children { get; private set; }
        
        public TrieNode() {
            this.Children = new Dictionary<char, TrieNode>();
        }
    }

    class ContactsBook
    {
        private TrieNode root = new TrieNode();

        public void Add(char[] name)
        {
            TrieNode node = root;
            TrieNode childNode = null;

            for (int i = 0; i < name.Length; i++)
            {
                node.Children.TryGetValue(name[i], out childNode);

                if (childNode == null)
                {
                    childNode = new TrieNode()
                    {
                        Letter = name[i],
                        IsEndOfWord = (i == name.Length - 1)
                    };
                    node.Children.Add(name[i], childNode);
                }

                childNode.WordsInSubtree++;
                node = childNode;
            }
        }

        public int Find(char[] name)
        {
            // Get to the last node for the partial string
            TrieNode node = root;
            TrieNode childNode = null;

            for (int i = 0; i < name.Length; i++)
            {
                node.Children.TryGetValue(name[i], out childNode);

                if (childNode == null)
                {
                    return 0;
                }

                node = childNode;
            }

            // Find all words in the tree
            return node.WordsInSubtree;
        }
    }
}
