using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class SingleNumber
    {
        public int RemoveNum(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            HashSet<int> numbers = new HashSet<int>(nums.Length+1/2);
            for(int iter = 0; iter < nums.Length; iter++)
            {
                if (numbers.Contains(nums[iter]))
                {
                    numbers.Remove(nums[iter]);
                }
                else
                {
                    numbers.Add(nums[iter]);
                }
            }
            int[] result =  numbers.ToArray();
            return result[0];
        }
    }
}
