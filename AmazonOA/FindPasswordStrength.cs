using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOA
{
    class FindPasswordStrength
    {
        public static int PasswordStrength(string inputString)
        {
            HashSet<char> vowels = new HashSet<char> {'a','e','i','o','u'};
            int count = 0;
            bool vowel = false;
            bool consonant = false;
            int index = 0;
            while( index < inputString.Length)
            {
                if (vowels.Contains(inputString[index]))
                {
                    vowel = true;
                }
                else
                {
                    consonant = true;
                }

                if (vowel==true && consonant == true)
                {
                    count++;
                    consonant = false;
                    vowel = false;
                }
                index++;
            }
            return count;
        }
    }
}
