using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOA
{
    class ConsecutiveDecreaseGroups
    {
        public static bool IsDecOrder(int[] subArray, int start, int end)
        {
            while (start != end)
            {
                if ((subArray[start] - subArray[start + 1]) != 1)
                {
                    return false;
                }
                start++;
            }
            return true;
        }
        public static int ConsecutiveDecGrp(int[] inputArray)
        {
            int count = inputArray.Length;
            for(int iter1 = 0; iter1 < inputArray.Length-1; iter1++)
            {
                for (int iter2 =iter1+1;iter2 <inputArray.Length; iter2++)
                {
                    bool result = IsDecOrder(inputArray, iter1, iter2);
                    if(result == true)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
