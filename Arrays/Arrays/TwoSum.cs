using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class TwoSum
    {
        public static int[] twoSum(int[] InputArray, int Sum)
        {
            int[] OutputArray = new int[2];
            for (int index1 = 0; index1 < InputArray.Length - 1; index1++)
            {
                for(int index2=index1+1;index2<InputArray.Length;index2++)
                
                if (InputArray[index1]+InputArray[index2] == Sum)
                {

                        OutputArray[0] = index1;
                        OutputArray[1] = index2;
                    return OutputArray;
                }
            }
            return OutputArray;
        }

        public static int[] twoSums(int[] InputArray, int sum)
        {
            int[] OutputArray = new int[2];
            HashSet<int> NewDict = new HashSet<int>(InputArray);
            
            foreach (int number in InputArray)
            {
                if (NewDict.Contains(sum - number))
                {
                    OutputArray[0] = number;
                    OutputArray[1] = sum - number;
                    return OutputArray;
                }
                
                
            }
            return OutputArray;
        }
    }
}
