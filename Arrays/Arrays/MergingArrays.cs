using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MergingArrays
    {
        
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j=0;
            int border = m;
            if (nums1.Length == 0 && nums2.Length != 0)
            {
                nums1 = nums2;
                return;
            }
            if (nums1.Length != 0 && nums2.Length == 0)
            {
                return;
            }
            else
            {
                while (j < n)
                    
                {
                    for (int i = 0; i < m + n; i++)

                    {
                        if (i==border)
                        {
                            nums1[i] = nums2[j];
                            j++;
                            border = border + 1;
                            break;
                        }
                        else if (nums2[j] < nums1[i])
                        {
                            int temp = nums1[i];
                            nums1[i] = nums2[j];
                            nums2[j] = temp;
                        }
                        
                    }

                    
                }

            }

           
        }
    }
}
