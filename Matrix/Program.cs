using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Mat = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 4, 5, 6, 7 }, new int[] { 7, 8, 9, 10 }, new int[] { 10, 11, 12, 13 } };
            int Sum = MatrixDiagonalSum.DiagonalSum(Mat);
            Console.WriteLine(Sum);
        }
    }
}
