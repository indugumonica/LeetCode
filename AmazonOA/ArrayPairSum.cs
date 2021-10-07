using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazonOA
{
    class ArrayPairSum
    {
        public int Sum(int[] nums)
        {
            int n = nums.Length;

           
            int max = nums.Max();

           
            int[] freq = new int[max + 1];

            for (int j = 0; j < n; j++)
            {
                freq[nums[j]]++;
            }

           
            int ans = 0, i = max;

            
            while (i > 0)
            {

                
                if (freq[i] > 0)
                {
                    
                    ans += i;

                    
                    freq[i - 1]--;

                   
                    freq[i]--;
                }
                else
                {
                    
                    i--;
                }
            }

            return ans;
        }



    }
}
