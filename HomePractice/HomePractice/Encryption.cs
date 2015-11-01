using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public void Encrypt(string input, int k)
    {
        string output = "";
        int len = input.Length;
        for (int i = 0; i < len; i++)
        {
            char c = input[i];

            // directly compare chars with alphabets.
            if (Char.IsLower(c))
            {
                // perform arithmetic operation on chars.
                output += (char)(((c + k - 'a') % 26) + 'a');
            }
            else if (Char.IsUpper(c))
            {
                output += (char)(((c + k - 'A') % 26) + 'A');
            }
            // characters other than alphabets.
            else
            {
                output += c;
            }
        }

        Console.WriteLine(output);
    }
}