using System;
using System.Collections.Generic;

namespace AmazonOA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Consecutively Decreasing Groups

            //int[] InputArray = { 1};
            //int Count = ConsecutiveDecreaseGroups.ConsecutiveDecGrp(InputArray);
            //Console.WriteLine(Count);



            //FindPasswordStrength

            //string InputString = "hackerrank";
            //int Output = FindPasswordStrength.PasswordStrength(InputString);
            //Console.WriteLine(Output);


            //FindAdjacentSwaps

            //int[] inputArray = { 0, 0, 1, 0, 1, 0 };
            //int Output = FindAdjacentSwaps.FindSwapCount(inputArray);
            //Console.WriteLine(inputArray);

            //KthClosestElement

            //int k = 1;
            //int[][] inputArray = { new int[] { 1, 3 }, new int[] { -2, 2 } };
            //int[][] outputArray = KthClosestElement.KClosest1(inputArray,k);
            //for(int i = 0; i < outputArray.Length; i++)
            //{
            //    Console.WriteLine(outputArray[i][0] + ","+outputArray[i][1]);
            //}


            //Count of Unique Characters of substring

            //string input = "LEETCODE";
            //var output = new UniqueCharacters();
            //int result = output.UniqueLetterString(input);
            //Console.WriteLine(result);


            //Optimal Utilization
            //int[][] a = { new int[] { 1, 8 }, new int[] { 2, 15 }, new int[] { 3, 9 }};
            //int[][] b = { new int[] { 1, 8}, new int[] { 2, 11}, new int[] { 3, 12}};
            //int target = 20;
            //var output = new OptimalUtilization();
            //List<List<int>> result = output.OptimalPair(a, b, target);
            //for(int i = 0; i < result.Count; i++)
            //{
            //    Console.WriteLine(result[i][0] + "," + result[i][1]);
            //}



            //MergeIntervals

            //int[][] input = { new int[] { 1, 4 }, new int[] { 0,1} };
            //var output = new MergeIntervals();
            //int[][] arrays = output.Merge(input);
            //foreach(int[] pair in arrays)
            //{
            //    Console.WriteLine(pair[0]+","+pair[1]);

            //}


            //reverse Number
            int x = 1534236469;
            var output = new integerreverse();
            int result = output.Reverse(x);
            Console.WriteLine(result);
        }
    }
}
