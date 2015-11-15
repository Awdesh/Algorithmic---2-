using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static int ConvertStringToInt(string s)
    {
		if(s.Equals(""))
		{
			return -1;
		}

		bool isNeg = false;
		char[] chArr = s.ToCharArray();
		if(chArr[0] == '-')
			isNeg = true;

		int len = chArr.Length;
		int num = 0;
		for(int i = 0; i < len; i++)
		{
			if(chArr[i] == '-')
				continue;
			int val = chArr[i] - '0';
			num = num * 10 + val;
		}

		if (isNeg)
			num *= -1;

		return num;
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
    static bool IsPalindrome(string ip)
    {

        if (ip.Length == 1)
            return true;

        if (ip == null || ip.Length <= 0)
            return false;


        int i = 0;
        int j = ip.Length - 1;
        char[] chArr = ip.ToCharArray();

        while (i <= j)
        {
            if (chArr[i] != chArr[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }

    /*
    
    */
    public static string Reverse(string word)
    {
        string[] arr = word.Split(' ');
        if (arr.Length == 1)
            return word;

        Stack<string> stack = new Stack<string>();

        foreach (string s in arr)
        {
            stack.Push(s);
        }

        StringBuilder sb = new StringBuilder();
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
            sb.Append(' ');
        }

        return sb.ToString();
    }

    public static char FindFirstNonRepeating(string ip)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        char[] chArr = ip.ToCharArray();

        for (int i = 0; i < chArr.Length; i++)
        {
            if (!map.ContainsKey(chArr[i]))
            {
                map.Add(chArr[i], 1);
            }
            else
            {
                map[chArr[i]]++;
            }
        }

        foreach (char c in map.Keys)
        {
            if (map[c] == 1)
            {
                return c;
            }
        }

        return ' ';
    }

    public static List<int> FindDuplicate(int[] arr)
    {
        int[] count = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            count[arr[i]] += 1;
        }

        List<int> l = new List<int>();
        for (int i = 0; i < count.Length; i++)
        {
            Console.WriteLine(count[i]);
            if (count[arr[i]] > 1)
            {
                l.Add(arr[i]);
            }
        }
        return l;
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
