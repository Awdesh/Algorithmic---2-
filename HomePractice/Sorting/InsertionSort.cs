using System;

namespace Sorting
{
	public class InsertionSort
	{
		public InsertionSort (int[] ar)
		{
			if(ar == null )
			{
				return;
			}

			int length = ar.Length;
			int temp = ar[length - 1];
			bool flag = false;

			for(int i = length - 2; i >= 0; i--)
			{
				if(ar[i] > temp)
				{
					ar[i + 1] = ar[i];
					PrintArray(ar);
				}
				else
				{
					ar[i + 1] = temp; 
					flag = true;
					PrintArray(ar);
					break;
				}
				Console.WriteLine ();
			}

			if (!flag) 
			{
				ar [0] = temp;
				PrintArray (ar);
			}

		}

		static void PrintArray(int[] arr)
		{
			for(int i = 0; i< arr.Length; i++)
			{
				Console.Write("{0}",arr[i]);
				Console.Write(" ");
			}
		}


	}
}

