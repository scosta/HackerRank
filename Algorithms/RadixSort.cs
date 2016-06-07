using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    class RadixSort
    {
        public void Sort(int[] numbers)
        {
            int radix = 10;
            int placement = 1;
            int val;
            List<int>[] buckets = new List<int>[radix];
            for (int i = 0; i < radix; i++)
            {
                buckets[i] = new List<int>();
            }


            bool maxLength = false;
            while (!maxLength)
            {
                maxLength = true;

                // Put into buckets
                for (int i = 0; i < numbers.Length; i++)
                {
                    val = numbers[i] / placement;
                    buckets[val % radix].Add(numbers[i]);
                    if (maxLength && val > 0)
                    {
                        maxLength = false;
                    }
                }

                // Put buckets back into array
                int index = 0;
                for (int i = 0; i < buckets.Length; i++)
                {
                    foreach (var num in buckets[i])
                    {
                        numbers[index++] = num;
                    }
                }

                // Increase placement
                placement *= radix;
                for (int i = 0; i < radix; i++)
                {
                    buckets[i].Clear();
                }
            }
        }
    }
}
