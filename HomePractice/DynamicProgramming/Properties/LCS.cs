using System;

namespace DynamicProgramming
{
	public class LCS
	{
		public LCS ()
		{

		}

		public int LongestCommonSubsequence(string X, string Y, int m, int n)
		{
			int[,] L = new int[7,7];
			int i, j;

			for (i=0; i<=m; i++) {
				for(j = 0;j<=n;j++)
				{
					if (i == 0 || j == 0) {
						L [i,j] = 0;
					} else if (X [i - 1] == Y [j - 1]) {
						L [i,j] = L [i - 1, j - 1] + 1;
					} else {
						L [i,j] = Math.Max (L [i - 1,j], L [i, j - 1]);
					}
				}
			}
			return L [m,n];
		}
	}
}

