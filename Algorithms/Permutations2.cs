using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    class Permutations2
    {
        public static void Compute(string text)
        {
            Compute(text, string.Empty);
        }

        private static void Compute(string text, string prefix)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine(prefix);
                return;
            }

            for (int i = 0; i < text.Length; i++)
            {
                Compute(text.Substring(0, i) + text.Substring(i + 1), prefix + text[i]);
            }
        }
    }
}
