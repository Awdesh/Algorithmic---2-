// This is the text editor interface.
// Anything you type or change here will be seen by the other person in real time.
using System;
using System.Collections.Generic;
using System.Text;

class Solution
{
    static List<int> FindDuplicateI(int[] arr)
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

    static List<int> FindDuplicateII(int[] arr)
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

    public static string ReverseWordsInSentence(string ip)
    {
        string[] strArr = ip.Split(' ');
        int len = strArr.Length;
        Stack<string> stack = new Stack<string>();

        foreach(string s in strArr)
        {
            stack.Push(s);
        }

        StringBuilder sb = new StringBuilder();
        foreach(string s in stack)
        {
            sb.Append(s);
            sb.Append(' ');
        }

        return sb.ToString();
    }

   public static int RemoveDuplicateI(int[] A)
    {
        int len = A.Length;
        int count = 0;
        int j = 0;
        for(int i = 0; i < len - 1; i++)
        {
            if ( j != 0)
            {
                A[j] = A[i + 1];
                j = 0;
            }
            if(A[i] == A[i + 1])
            {
                j = i + 1;
                Console.WriteLine("in");
                ++count;
            }
        }

        while(count > 0)
        {
            A[len - 1] = 0;
            --count;
        }
        return count;
    }

    public static int Calculate(string ip)
    {
        char[] chArr = ip.ToCharArray();
        Stack<char> opStack = new Stack<char>();
        Stack<int> numStack = new Stack<int>();

        foreach(char c in chArr)
        {
            if(c == '*' || c == '+' || c == '-' || c == '/' || c == '(' )
            {
                opStack.Push(c);
            }
            if(c == ')')
            {
                int val1 = Convert.ToInt32(numStack.Pop());
                int val2 = Convert.ToInt32(numStack.Pop());
                //Console.WriteLine("*$*$*$-: {0},{1}",val1,val2 );
                char c1 = opStack.Pop();
                numStack.Push(performOperation(c1, val1, val2));

                // int mul = val2 * val1;
                // numStack.Push(mul);
            }
            else
            {
                numStack.Push(Convert.ToInt32(c));
            }
        }



        return numStack.Pop();
    }

    private static int performOperation(char c, int num1, int num2)
    {
        switch(c)
        {
            case '+' :
               return num1 + num2;
            case '-' :
                return num1 - num2;
            case '*' :
                return num1 * num2;
            case '/' :
                return num1 / num2;
        }
        return 0;
    }

    public static string ReverseString(string ip)
    {
        int i = 0;
        int j = ip.Length - 1;
        char[] chArr = ip.ToCharArray();

        while(i<=j)
        {
            if(!char.IsLetter(chArr[i]))
            {
                Console.WriteLine("ii");
                i++;
                continue;
            }

            if(!char.IsLetter(chArr[j]))
            {
                Console.WriteLine("jj");
                j--;
                continue;
            }

            char temp = chArr[i];
            chArr[i] = chArr[j];
            chArr[j] = temp;
            i++;
            j--;
        }

        return new string(chArr);
    }

    /*
     If array is [2, 3, 10, 6, 4, 8, 1] then returned value should be 8
     (Diff between 10 and 2). If array is [ 7, 9, 5, 6, 3, 2 ]
    */
    public static int MaxContiguosDifferenceI(int[] A)
    {
        int len = A.Length;
        int diff = 0;

        for(int i = 0; i < len; i++)
        {
            for(int j = i+1; j < len; j++)
            {
                 if(diff < A[j] - A[i])
                 {
                    diff = A[j] - A[i];
                 }
            }
        }

        return diff;
    }

    /*
     If array is [2, 3, 10, 6, 4, 8, 1] then returned value should be 8
     (Diff between 10 and 2). If array is [ 7, 9, 5, 6, 3, 2 ]
    */
    public static int MaxContiguosDifferenceII(int[] A)
    {
        {
          int max_diff = arr[1] - arr[0];
          int min_element = arr[0];
          int i;
          for(i = 1; i < arr_size; i++)
          {
            if (arr[i] - min_element > max_diff)
              max_diff = arr[i] - min_element;
            if (arr[i] < min_element)
                 min_element = arr[i];
          }
          return max_diff;
    }

    static void Main(string[] args)
    {
        int[] arr = new int[]{1,2,3,2,4,5,5};
        List<int> l = FindDuplicateI(arr);
        Console.WriteLine("****");
        foreach(int i in l)
            Console.WriteLine(i);

        Console.WriteLine("****");
        List<int> l1 = FindDuplicateII(arr);
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

        Console.WriteLine("****");
        string op2 = ReverseWordsInSentence("This is a demo sentence.");
        Console.WriteLine(op2);

        Console.WriteLine("****");
        int[] A1 = new int[]{3,2,2,5,6,6,7,8,8};
        int len = RemoveDuplicateI(A1);
        Console.WriteLine(len);
        Console.WriteLine("****");
        foreach(int i in A1)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("****");
        int ii = Calculate("5 + (2+3) * 2");
        Console.WriteLine(ii);

        Console.WriteLine("****");
        string rev = ReverseString("This$is$%$a*&demo sentence.");
        Console.WriteLine(rev);

        Console.WriteLine("****");
        int[] AA = new int[]{7,5,4,3,6,4};
        int diff = MaxContiguosDifferenceI(AA);
        Console.WriteLine(diff);

        Console.WriteLine("****");
        int[] AA1 = new int[]{2,3,10,6,4,8,1};
        int diff1 = MaxContiguosDifferenceII(AA1);
        Console.WriteLine(diff1);

    }
}
