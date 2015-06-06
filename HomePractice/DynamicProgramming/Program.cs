using System;

namespace DynamicProgramming
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			LCS lcs = new LCS ();
			int L = lcs.LongestCommonSubsequence ("ABCDGH", "AEDFHR", 6,6);
		}
	}
}
