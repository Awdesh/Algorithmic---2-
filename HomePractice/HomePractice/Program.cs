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

            //fibonacci f = new fibonacci ();
            //int n = f.CalculateFibonacci (8);

//            Combination combs = new Combination("wxyz");
//            combs.Combine();

			string s = "Awdes   S h ar ma";
			FindQuotesInString f = new FindQuotesInString (s);
		}

	}
}
