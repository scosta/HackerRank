using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class Permutations
    {
        public static List<string> Compute(string text)
        {
            List<string> result = new List<string>();
            Compute(result, text.ToCharArray(), null);
            return result;
        }

        private static void Compute(List<string> result, char[] text, char? prefix)
        {
            if ((text == null || text.Length == 0) && prefix == null)
                return;

            if (text != null && text.Length > 0)
            {
                char newPrefix = text[0];
                char[] newText = text.Skip(1).Take(text.Length - 1).ToArray();
                Compute(result, newText, newPrefix);
            }

            if (prefix != null)
            {
                if (result.Count == 0)
                {
                    result.Add(prefix.ToString());
                }
                else
                {
                    List<string> newResult = new List<string>();
                    foreach (string p in result)
                    {
                        newResult.AddRange(Weave(prefix, p));
                    }
                    result.Clear();
                    result.AddRange(newResult);
                }
            }
        }

        private static List<string> Weave(char? p, string text)
        {
            List<string> result = new List<string>();
            if (p == null || string.IsNullOrEmpty(text))
                return result;

            for (int i = 0; i <= text.Length; i++)
            {
                string item = text.Insert(i, p.ToString());
                result.Add(item);
            }
            
            return result;
        }
    }
}
