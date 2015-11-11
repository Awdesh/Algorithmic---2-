using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static List<int> ConvertStringToInt(string s)
    {
        List<int> list1 = new List<int>();
        if(s.Equals(""))
        {
            list1.Add(-1);
            return list1;
        }

        char[] chArr = s.ToCharArray();
        int len = chArr.Length;

        for(int i = 0; i < len; i++)
        {
            if(chArr[i] == ' ')
                continue;
            int val = chArr[i] - '0';
            list1.Add(val);
        }

        return list1;
    }

    static List<char> ConvertIntToString(int num)
   {
       List<char> list1 = new List<char>();
       Stack<int> s = new Stack<int>();

       int rev = 0;
       while(num > 0)
       {
           num %= 10;
           rev = rev * 10 + num;
           s.Push(rev);
           num /= 10;
       }

        while(s.Count > 0)
        {
            int i = s.Pop();
            int val = i + '0';
            char c = (char)val;
            list1.Add(c);
        }

       return list1;
   }

   static void Main(string[] args)
   {
       List<char> l = ConvertIntToString(1234);
       foreach (char i in l)
       {
           Console.Write(i);
       }
   }

    static void Main(string[] args)
    {
        List<int> l = ConvertStringToInt("12 34");
        foreach (int i in l)
        {
            Console.Write(i);
        }
    }
}
