using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class UnboundedKnapsack2
    {
        public static int GetMaxSum(int expectedSum, int[] numbers)
        {
            return expectedSum - GetMinRemainder(expectedSum, numbers, 0);
        }

        private static int GetMinRemainder(int expectedSum, int[] numbers, int index)
        {
            if (index >= numbers.Length || expectedSum == 0)
            {
                return expectedSum;   // Can't go any further
            }

            int currentNumber = numbers[index];
            int newAmountRemaining = expectedSum;

            for (int i = 0; i * currentNumber <= expectedSum; i++)
            {
                int amountRemaining = expectedSum - i * currentNumber;
                newAmountRemaining = Math.Min(newAmountRemaining, GetMinRemainder(amountRemaining, numbers, index + 1));
                if (newAmountRemaining == 0)
                {
                    // We found the best solution
                    break;
                }
            }

            return newAmountRemaining;
        }
    }
}
