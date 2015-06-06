using System;
using System.Text;

namespace HomePractice
{
	public class ReverseInt
	{
		public int Reverse(int x) {
			if (x == 0) {
				return 0;
			}
			bool isNeg = false;
			if(x < 0)
			{
				x *= -1;
				isNeg = true;
			}

			int reversedInt = 0;
			StringBuilder sb = new StringBuilder();
			while(x >= 1)
			{
				reversedInt = x %10;
				sb.Append(reversedInt);
				x = x/10;    
			}

			string s = sb.ToString ();
			reversedInt = Convert.ToInt32 (s);

			if(isNeg)
			{
				reversedInt *= -1;
			}

			return reversedInt;
		}
	}
}

