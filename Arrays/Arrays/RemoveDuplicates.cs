using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class RemoveDuplicates
    {
        public static int RemoveDuplicate(int[] nums)
        {
           

            int min = 0;
            List<int> numbers = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > min)
                {
                    numbers.Add(nums[i]);
                    min = nums[i];
                }
            }
            return numbers.Count;
        }
    }
}
