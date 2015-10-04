using System;

namespace Sorting
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.WriteLine ("Hello World!");
			int[] arr = new int[] { 5,8,1,3,7,9,2};
			QuickSort sort = new QuickSort ();
			sort.quickSort (arr);
			//int[] ar = HeapSort.Sort (arr);
			//int len = ar.Length;
		}
	}
}
