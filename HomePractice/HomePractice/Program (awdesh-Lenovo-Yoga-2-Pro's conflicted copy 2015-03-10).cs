using System;

namespace HomePractice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

//			FindSumOfDivisibles fd = new FindSumOfDivisibles ();
//			int sum = fd.FindSum (1000);
//			Console.WriteLine ("sum is-: {0}", sum);

//			Factors fact = new Factors ();
//			System.Collections.ArrayList li = fact.FindFactors (48);
//			Console.WriteLine ("values are -: {0}", li);

//			FindPrimeNumber f = new FindPrimeNumber ();
//			bool b = f.IsPrime (-2);
//			Console.WriteLine (" number is prime , and it is a -: {0}", b + " statement");

//			PrimeFactors pf = new PrimeFactors ();
//			System.Collections.ArrayList ll  = pf.FindPrimeFactors (18);
//			Console.WriteLine ("prime factors count is-: {0}", ll.Count);

//			factorial f = new factorial ();

//			fibonacci f = new fibonacci ();
//			int n = f.CalculateFibonacci (8);

//			ClockTopCoder clock = new ClockTopCoder ();
//			string s = clock.whatTime (3661);
//			Console.WriteLine ("{0}", s);

			int[] arr = new int[5];
			arr [0] = 1;
			arr [1] = 5;
			arr [2] = 2;
			arr [3] = 4;
			arr [4] = 6;

			SecondLargest sec = new SecondLargest ();
			int l = sec.FindSecondLargest (arr);
			Console.WriteLine ("Second largest element is-: {0}", l);

//			Solution ts = new Solution();
//			var p = ts.TwoSumOptimized(arr,9);
//			Console.WriteLine ("{0}", p);

//			ReverseInt rev = new ReverseInt ();
//			int r = rev.Reverse (-123);
//			Console.WriteLine("Value of reverse int is-: {0}",r);




		}

	}
}
