using System;
using System.Collections.Generic;

namespace Sorting
{
	public class QuickSort
	{
		public QuickSort ()
		{

		}

		public void quickSort(int[] ar)
		{
			int length = ar.Length;
			int p = ar[0];
			List<int> list1 = new List<int>();
			List<int> list2 = new List<int>();
			for(int i = 1; i < length; i++)
			{
				if(ar[i] < p)
				{
					list1.Add(ar[i]);
				}
				else
				{
					list2.Add(ar[i]);
				}
			}

			if(list1.Count == 0 )
			{
				quickSort (list2.ToArray ());
				foreach(int item in list2)
					Console.Write(p + " " + item );
			}
			if(list2.Count == 0)
			{
				quickSort (list1.ToArray ());
				foreach(int item in list2)
					Console.Write(item + " " + p);
			}
			else
			{
				if(list1.Count > 1)
					quickSort(list1.ToArray());
				if(list2.Count > 1)
					quickSort(list2.ToArray());

			}

			if(list1.Count == 1 && list2.Count == 1 || list1.Count == 1 && list2.Count == 1)
			{
				Console.Write(list1[0] + " " + p + " " + list2[0]);
			}
		}
	}
}
