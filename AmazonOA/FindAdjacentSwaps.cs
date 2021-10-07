using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOA
{
    class FindAdjacentSwaps
    {
        public static int CheckAndSwap(int[] inputArray, int index)
        {
            int count = 0;
            while (inputArray[index] != inputArray[index - 1])
            {
                count++;
                int temp = inputArray[index - 1];
                inputArray[index - 1] = inputArray[index];
                index--;
                if (index == 0)
                {
                    return count;
                }
            }
            return count;
        }
        public static int FindSwapCount(int[] inputArray)
        {
            int count=0;
            for(int index = 0; index < inputArray.Length-1; index++)
            {
                if (inputArray[index] == inputArray[index+1])
                {
                    continue;
                }
                else
                {
                    for(int iter = index + 1; iter < inputArray.Length - 1; iter++)
                    {
                        if (inputArray[iter] == inputArray[iter + 1])
                        {
                            continue;
                        }
                        else
                        {
                            count += CheckAndSwap(inputArray, iter + 1);
                        }
                    }
                }
            }
            return count;
        }
    }
}
