using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Challenges;
using HackerRank.DataStructures;
using HackerRank.Algorithms;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            TestUnboundedKnapsack();
        }

        private static void TestLCA()
        {
            LCA.Node root = new LCA.Node();
            LCA.Node p = new LCA.Node();
            LCA.Node q = new LCA.Node();
            LCA.Node lca = LCA.GetLCA(root, p, q);
        }

        private static void TestUnboundedKnapsack()
        {
            int expectedSum = 13;
            int[] arr = { 3, 10, 4 };
            Console.WriteLine(UnboundedKnapsack2.GetMaxSum(expectedSum, arr));
            Console.ReadLine();
        }

        private static void TestMultiplication()
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(string.Format("-------{0}-------", i));
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine(string.Format("{0} * {1} = {2}", i, j, Multiply.Compute2(i, j)));
                }
            }
            Console.ReadLine();
        }

        private static void TestPermutations()
        {
            string test = "abc";
            Permutations2.Compute(test);
            Console.ReadLine();
        }

        private static void TestRadixSortAndBinarySearch()
        {
            int[] numbers = new int[11] { 18, 5, 100, 3, 1, 19, 6, 0, 7, 4, 2 };
            (new RadixSort()).Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine("Enter number to search for: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((new BinarySearch()).Search(numbers, key, 0, numbers.Length - 1));
            Console.ReadLine();
        }

        private static void TestMergeSort()
        {
            int[] numbers = new int[21] { 210, 200, 190, 180, 170, 160, 150, 140, 130, 120, 110, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
            (new RadixSort()).Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            Console.ReadLine();
        }

        private static void TestQuickSort()
        {
            int[] numbers = new int[21] { 210, 200, 190, 180, 170, 160, 150, 140, 130, 120, 110, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
            (new QuickSort()).Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            Console.ReadLine();
        }
    }
}
