using System;

namespace Miscellaneous
{
	/// <summary>
	/// All valid pair of paranthesis.
	/// </summary>
	public class AllValidPairOfParanthesis
	{
		public AllValidPairOfParanthesis ()
		{
		}

		/// <summary>
		/// Prints the paranthesis.
		/// </summary>
		/// <param name="pos">Position.</param>
		/// <param name="n">N.</param>
		/// <param name="open">Open.</param>
		/// <param name="close">Close.</param>
		/// <param name="str">String.</param>
		public void PrintParanthesis(int pos, int n, int open, int close, char[] str)
		{
			if (close == n) {
				Console.WriteLine ("{0}", new string(str));
				return;
			} else {
				if (open > close) {
					str [pos] = '}';
					PrintParanthesis (pos + 1, n, open, close + 1, str);
				}
				if (open < n) {
					str [pos] = '{';
					PrintParanthesis (pos + 1, n, open + 1, close, str);
				}
			}
		}
	}
}

