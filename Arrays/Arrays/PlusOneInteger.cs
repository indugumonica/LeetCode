using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class PlusOneInteger
    {
        public static int[] plusOne(int[] digits)
        {
            int length = digits.Length-1;
            int[] outputArray = new int[digits.Length + 1];
            digits[length] += 1;
            while(digits[length]>9&& length > 0)
            {
                digits[length] = 0;
                digits[length - 1] +=1;
                length--;
            }
            if (digits[length] > 9)
            {
                outputArray[0] = 1;
                outputArray[1] = 0;
                for(int i = 2; i < outputArray.Length; i++)
                {
                    outputArray[i] = digits[i-1];
                }
                return outputArray;
            }
            return digits;

        }
    }
}
