using System;

namespace Test
{
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			MainClass.Test1(123);
			Console.WriteLine ("Hello World!");
		}

		/// <summary>
		/// Test this instance.
		/// </summary>
		public static void Test1(int d)
		{

			if (d < 0) {
				Console.WriteLine ("-");
				Test1 (-d);
			} else if (d < 10) {
				Console.WriteLine (d);
			} else {
				Test1 (d / 10);
				Console.WriteLine (d % 10);
			}
		}
	}
}
