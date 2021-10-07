using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOA
{
    class OptimalUtilization
    {
        public List<List<int>> OptimalPair(int[][] a,int[][] b,int target)
        {
            int max = 0;
            List<List<int>> result = new List<List<int>>();
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    int sum = a[i][1] + b[j][1];
                    if (sum <= target)
                    {
                        if (sum > max)
                        {
                            max = sum;
                            result = new List<List<int>>();
                            List<int> sublist = new List<int>();
                            
                            sublist.Add(a[i][0]);
                            sublist.Add(b[j][0]);
                            result.Add(sublist);

                        }
                        else if  (sum == max)
                        {
                            List<int> sublist = new List<int>(2);
                            sublist.Add(a[i][0]);
                            sublist.Add(b[j][0]);
                            result.Add(sublist);
                        }
                        
                    }
                }
            }
            return result;
        }
    }
}
