using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MaxProductofThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            int product = 1;
            int count = 0;
            int max = nums[0];
            int temp = 0;
            int[] maxThree = new int[3];
            int length = nums.Length;
            if (nums.Length == 3)
            {
                foreach (int num in nums)
                {
                    product = product * num;
                }

            }
            else
            {
                while (count < 3)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (max < nums[i])
                        {
                            max = nums[i];
                            temp = i;
                        }
                    }

                    int temp2 = nums[length - 1];
                    nums[length - 1] = nums[temp];
                    nums[temp] = temp2;
                    maxThree[count] = max;
                    max = nums[0];
                    length = length - 1;
                    count++;

                }
                for (int iter = 0; iter < maxThree.Length; iter++)
                {
                    product = product * maxThree[iter];
                }

            }
            return product;
        }
    }
}
