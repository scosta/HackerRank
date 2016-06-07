using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    class BinarySearch
    {
        public int Search(int[] items, int key, int low, int high)
        {
            if (low > high)
                return -1;

            int middle = (low + high) / 2;

            if (items[middle] == key)
            {
                return items[middle];
            }

            if (items[middle] > key)
            {
                return Search(items, key, low, middle - 1);
            }
            else
            {
                return Search(items, key, middle + 1, high);
            }
        }
    }
}
