using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class StringToInteger
    {
        public int MyAtoi(string s)
        {
            int sign = 1;
            int num = 0;
            int result=0;
            for(int iter = 0; iter < s.Length; iter++)
            {
                if(s[iter] == ' ')
                {
                    continue;
                }
                if(s[iter] == '-')
                {
                    sign = -1;
                }
                if (!Char.IsDigit(s[iter]))
                {
                    break;
                }
                int asci = (int)s[iter] - '0';
                if(asci >0 && asci <= 9)
                {
                    num = asci;
                }
                if (iter == s.Length - 1)
                {
                    result = result + num;
                }
                else
                {
                    result = (result + num) * 10;
                }
            }
            return result;

        }
    }
}
