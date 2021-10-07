using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MaximumSubArray
    {
        public static int MaxSubArray(int[] nums)
        {

            int max = 0;
            int sum = 0;
            int min = nums[0];
            for (int index = 0; index < nums.Length; index++)
            {
                sum = sum + nums[index];
                if (max < sum)
                {
                    max = sum;
                }
                if (min < sum)
                {
                    min = sum;
                }

                if (sum < 0)
                {

                    sum = 0;

                }


            }
            if (max == 0)
            {
                return min;
            }
            return max;
        }
    }
}
