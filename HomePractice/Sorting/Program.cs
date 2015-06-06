using System;

namespace Sorting
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.WriteLine ("Hello World!");
			int[] arr = new int[] { 2,5,3,7,9};
			int[] ar = HeapSort.Sort (arr);
			int len = ar.Length;
		}
	}
}
