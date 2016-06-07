using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class QuickSort
    {
        public void Sort(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int p = HoarePartition(arr, left, right);
            Sort(arr, left, p);
            Sort(arr, p + 1, right);
        }

        private int HoarePartition(int[] arr, int left, int right)
        {
            int i = left,
                j = right,
                p = (left + right) / 2;

            while (i < j)
            {
                while (arr[i] < arr[p])
                {
                    i++;
                }
                while (arr[j] > arr[p])
                {
                    j--;
                }

                if (i < j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            return p;
        }
    }
}
