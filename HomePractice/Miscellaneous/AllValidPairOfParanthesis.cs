using System;

namespace Miscellaneous
{
	public class AllValidPairOfParanthesis
	{
		public AllValidPairOfParanthesis ()
		{
		}


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

