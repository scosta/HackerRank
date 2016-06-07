using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class MergeSort
    {
        public void Sort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            Sort(array, 0, array.Length - 1);
        }

        private void Sort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            int p = (left + right) / 2;
            Sort(array, left, p);
            Sort(array, p + 1, right);
            Merge(array, left, p, p + 1, right);
        }

        private void Merge(int[] array, int left1, int right1, int left2, int right2)
        {
            int i = left1, j = left2;
            List<int> mergedArray = new List<int>();
            while (i <= right1 && j <= right2)
            {
                if (array[i] < array[j])
                {
                    mergedArray.Add(array[i]);
                    i++;
                }
                else
                {
                    mergedArray.Add(array[j]);
                    j++;
                }
            }

            if (i < right1)
            {
                while (i <= right1)
                {
                    mergedArray.Add(array[i]);
                    i++;
                }
            }
            else
            {
                while (j <= right2)
                {
                    mergedArray.Add(array[j]);
                    j++;
                }
            }

            // Put sorted items back in array
            for (int t = left1, y = 0; t <= right2; t++, y++)
            {
                array[t] = mergedArray[y];
            }
        }
    }
}
