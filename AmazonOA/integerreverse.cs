using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOA
{
    class integerreverse
    {
        public int Reverse(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            List<int> number=new List<int>();
            int div = x / 10;
            int rem = x%10;
            number.Add(rem);
            while (div != 0)
            {
                
                rem = div % 10;
                div = div / 10;
                number.Add(rem);

            }
            int total = 0;
            foreach (int entry in number)
            {
                total = 10 * total + entry;
            }
             << total << '\n';

            return reversed * sign;
        }
    }
}
