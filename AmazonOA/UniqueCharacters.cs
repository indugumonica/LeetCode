using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonOA
{
    class UniqueCharacters
    {
        private int CalculateUniquecChars(string input)
        {
            int eachcount=0;
            
            Dictionary<char,int> caculatechars = new Dictionary<char, int>();
            for (int index = 0; index < input.Length; index++)
            {
                if (caculatechars.ContainsKey(input[index]))
                {
                    caculatechars[input[index]]++;
                    
                }
                else
                {
                    caculatechars.Add(input[index], 1);
                    
                }
                
                
            }
            foreach(var kvp in caculatechars)
            {
                if (kvp.Value == 1)
                {
                    eachcount += 1;
                }
            }

            return eachcount ;
        }

        public  int UniqueLetterString(string s)
        {
            
            int count = 0;
            for(int i = 0; i < s.Length-1; i++)
            {
                string letter = s[i].ToString();
                count = count+CalculateUniquecChars(letter);
                for (int j = i + 1; j < s.Length; j++)
                {
                    letter = letter + s[j].ToString();
                    count = count + CalculateUniquecChars(letter);
                    
                    
                }
            }

            count = count + CalculateUniquecChars(s[s.Length - 1].ToString());
            
            return count;
        }
    }
}
