using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length;
            int mid;
            while (low < high)
            {
                mid = low + (high-low) / 2;
                if (target == nums[mid])
                {
                    return mid;

                }
                else if (target < nums[mid])
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low;
          
        }
    }
}
