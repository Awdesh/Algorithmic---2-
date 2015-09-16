using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomePractice
{
    static class AnagramStrings
    {
        private const int NO_OF_CHARS = 256;
        /// <summary>
        /// Method verifies if two strings are anagram of each other or not.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>boolean value either true or false</returns>
        public static bool AreStringsAnagram(string s1, string s2)
        {
            int[] count = new int[NO_OF_CHARS];

            foreach(char c in s1.ToCharArray())
            {
                if(count[c] == 0)
                    count[c]++;
            }

            foreach (char c in s2.ToCharArray())
            {
                if(count[c] == 1)
                    count[c]--;
            }

            for(int i = 0; i< NO_OF_CHARS; i++)
            {
                if(count[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
