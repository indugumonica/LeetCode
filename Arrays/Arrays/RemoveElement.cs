using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class RemoveElement
    {
        public static int RemoveElements(int[] nums, int val)
        {
            int position = 0;
            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index] == val)
                {
                    nums[index] = 0;
                }
                
                else if(nums[position] != nums[index])
                {
                    nums[position] = nums[index];
                    nums[index] = 0;
                    position = position + 1;
                }
                else
                {
                    nums[position] = nums[index];
                    position = position + 1;
                }       
                
            }
            return position;

        }
    }

}

