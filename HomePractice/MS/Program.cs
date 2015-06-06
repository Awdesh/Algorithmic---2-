using System;
using System.Collections.Generic;

namespace MSSelection
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			int[] inputArray = new int[] { 2, 4, 6,8,10,12,11, 1, 3, 5 };

			FindIndexofSwitch find = new FindIndexofSwitch();
			int index = find.FindIndex (null);
			Console.WriteLine ("Index is-: {0}", index);

//			Dictionary<string,string> map = new Dictionary<string, string> ();
//			map.Add ("A", "C");
//			map.Add ("B", "C");
//			map.Add ("C", "F");
//			map.Add ("D", "E");
//			map.Add ("E", "F");
//			map.Add ("F", "F");
//			Hierarchy h = new Hierarchy ();
//			Dictionary<string,int> res = h.CreateHierarchy (map);
//			string s = IntToString.Converter (125);

//			DuplicateInString dup = new DuplicateInString ();
//			dup.FindDupBad ("Honolulu");
//			StringSplit s = new StringSplit ();
//			bool b1 = s.IsValidIp("125.23.43.1");	// valid Ip.
//			bool b2 = s.IsValidIp ("192.121.34.3"); // valid Ip.
//			bool b3 = s.IsValidIp ("192.512.34.3"); // Invalid Ip.
//			bool b4 = s.IsValidIp ("192.121.34.abc"); // Invalid Ip.
//
//			IntToString Is = new IntToString();
//			string op = Is.Converter (732);
//			Console.WriteLine (op);

//			MethodToAdd mA = new MethodToAdd ();
//			string op = mA.demo ("5", "10");
//			Console.WriteLine (op);

//			int[,] mat = new int[,]
//			{
//				{10, 20, 30, 40},	
//				{15, 25, 35, 45},
//				{27, 29, 37, 48},
//				{32, 33, 39, 50},
//			};
//
//			MatrixSearch ms = new MatrixSearch ();
//			// bool b = ms.FindElem (mat, 29);
//			int rows = mat.GetLength (0);
//			int cols = mat.GetLength (1);
//
//			bool b1 = ms.FindElemBinarySearch (mat, 29, rows, cols);
//			int[] arr = new int[]  { 0, 1, 5, 1, 4, 5, 3, 2};
//
//			CountingSort cs = new CountingSort ();
//			cs.CountingSortExample (arr);
		}
	}
}
