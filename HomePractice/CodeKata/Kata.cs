// This is the text editor interface.
// Anything you type or change here will be seen by the other person in real time.
using System;
using System.Collections.Generic;
using System.Text;

class Solution
{
    static List<int> DuplicateI(int[] arr)
    {
        int len = arr.Length;
        int[] countArr = new int[++len];
        List<int> l = new List<int>();

        for(int i = 0 ; i < arr.Length; i++)
        {
            if(countArr[arr[i]] == 1)
                l.Add(arr[i]);
            else
            countArr[arr[i]] = 1;
        }

        return l;
    }

    static List<int> DuplicateII(int[] arr)
    {
        int len = arr.Length;
        List<int> l = new List<int>();

        for(int i = 0; i < len; i++)
        {
            if(arr[Math.Abs(arr[i])] < 0)
                l.Add(Math.Abs(arr[i]));

            arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
        }

        return l;
    }

    static int FindMissingNumber(int[] arr)
    {
        int len = arr.Length;
        for(int i = 0; i < len; i++)
        {
            if(arr[Math.Abs(arr[i])] < 0)
                continue;
            arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
        }

        foreach(int i in arr)
            Console.WriteLine(i);

        for(int i = 0; i < len; i++)
        {
            if(arr[i] > 0)
                return i;
        }

        return -1;
    }

    static int FindMissingPositive(int[] A)
    {
        int n = A.Length;
        for(int i = 0; i < n; i++)
        {
            if ( (A[i]>0)&&(A[i]<=n))
            {
                while(A[i] != i+1)
                {
                    if ((A[i]>n)||(A[i]<=0)||(A[A[i]-1]==A[i]))
                        break;
                    int tmp = A[A[i]-1];
                    A[A[i]-1]=A[i];
                    A[i]=tmp;
                }
            }
        }

        int j=0;
        for (; j<n;j++){
            if (A[j]!=(j+1)){
                return j+1;
            }
        }
        return j+1;
    }

    public static string Reverse(string ip)
    {
        char[] chArr = ip.ToCharArray();
        List<int> l = new List<int>();
        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < chArr.Length; i++)
        {
            if(chArr[i] == ' ')
                l.Add(i);
            else
                stack.Push(chArr[i]);
        }

        StringBuilder sb = new StringBuilder();
        int count = 0;
        while(stack.Count > 0)
        {
            if(l.Contains(count))
            {
                sb.Append(' ');
            }
            else
            {
                sb.Append(stack.Pop());
            }
            ++count;
        }

        return sb.ToString();
    }

    public static string ReverseConstantSpace(string ip)
    {
        int i = 0;
        int j = ip.Length -1;
        char[] chArr = ip.ToCharArray();

        while(i < j)
        {
            if(chArr[i] == ' ')
            {
                i++;
                continue;
            }

            if(chArr[j] == ' ')
            {
                j--;
                continue;
            }

            char temp = chArr[i];
            chArr[i] = chArr[j];
            chArr[j] = temp;
            i++;
            j--;
        }

        return chArr.ToString();
    }

    static void Main(string[] args)
    {
        int[] arr = new int[]{1,2,3,2,4,5,5};
        List<int> l = DuplicateI(arr);
        Console.WriteLine("****");
        foreach(int i in l)
            Console.WriteLine(i);

        Console.WriteLine("****");
        List<int> l1 = DuplicateII(arr);
        foreach(int i in l1)
            Console.WriteLine(i);

        Console.WriteLine("****");
        int[] ar = new int[]{1,2,4,5,6,1,2};
        Console.WriteLine(FindMissingNumber(ar));

        Console.WriteLine("****");
        int[] A = new int[]{3,2,5,1,7};
        Console.WriteLine(FindMissingPositive(A));

        Console.WriteLine("****");
        string op = Reverse("this is it....");
        Console.WriteLine(op);

        Console.WriteLine("****");
        string op1 = ReverseConstantSpace("a if");
        Console.WriteLine(op);
    }
}
