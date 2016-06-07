using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class UnboundedKnapsack
    {
        public static int MaxSum(int[] arr, int expectedSum)
        {
            // Set up matrix
            int maxSum = int.MinValue;
            int numWeights = expectedSum;
            int numItems = arr.Length;
            int[,] matrix = new int[numItems, numWeights];
            for (int i = 0; i < numItems; i++)
            {
                for (int j = 0; j < numWeights; j++)
                {
                    matrix[i, j] = ComputeMaxForCell(matrix, arr[i], i, j);

                    if (matrix[i, j] > maxSum)
                    {
                        maxSum = matrix[i, j];
                        if (maxSum == expectedSum)
                        {
                            return maxSum;
                        }
                    }
                }
            }
            return maxSum;
        }

        private static int ComputeMaxForCell(int[,] matrix, int itemWeight, int i, int j)
        {
            int result = 0;
            int weight = j + 1;
            int maxItemsForGivenWeight = weight / itemWeight;

            for (int numItems = 0; numItems <= maxItemsForGivenWeight; numItems++)
            {
                int remainingWeight = weight - (numItems * itemWeight);
                int additionalItemValue = 0;
                if (i - 1 >= 0 && remainingWeight - 1 >= 0)
                {
                    additionalItemValue = matrix[i - 1, remainingWeight - 1];
                }
                int prevItemMaxValue = (i - 1 >= 0) ? matrix[i - 1, j] : 0;

                int tempMax = Math.Max(maxItemsForGivenWeight * itemWeight + additionalItemValue, prevItemMaxValue);
                if (tempMax > result && tempMax <= weight)
                {
                    result = tempMax;
                }
            }

            return result;
        }
    }
}
