using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class MatrixDiagonalSum
    {
        public static  int DiagonalSum(int[][] mat)
        {
            //int row = mat.GetLength(0);
            //int column = mat.GetLength(1);
            int rowiter = mat.GetLength(0)-1;
            int columniter = 0;
            List<int> DiagonalList = new List<int>();
            for(int rowIter= 0; rowIter < mat.GetLength(0); rowIter++)
            {
                int Position;
                Position = mat[rowIter][rowIter];
                DiagonalList.Add(Position);
                
            }
            while (rowiter >= 0)
            {
                if (rowiter != columniter)
                {
                    int Position;
                    Position = mat[rowiter][columniter];
                    DiagonalList.Add(Position);
                    
                }
                rowiter--;
                columniter++;
            }
            int sum = 0;
            for(int i = 0; i < DiagonalList.Count; i++)
            {
                
                sum = sum + DiagonalList[i];
            }
            return sum;
        }
    }
}
