using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class DissapearedNumbers
    {
        
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> IList = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i];
                nums[i] = nums[temp - 1];
                nums[temp - 1] = temp;
            }
            for(int i = 1; i <= nums.Length; i++)
            {
                if (nums[i - 1] != i)
                {
                    IList.Add(i);
                }
            }
            return IList;
           

        }
    }
}
