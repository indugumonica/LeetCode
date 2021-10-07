using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MiisingNumber
    {
        public void MoveZeroes(int[] nums)
        {
            int i = 0;
            while (i < nums.Length - 1)
            {
                if (nums[i] == 0)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (j == nums.Length - 1 && nums[j] == 0)
                        {
                            i = nums.Length - 1;
                        }
                        if (nums[j] != 0)
                        {
                            nums[i] = nums[j];
                            nums[j] = 0;
                            i++;
                            break;
                        }
                    }

                }
                else
                {
                    i++;
                }

            }
        }
    }
}
