using System;

namespace HomePractice
{
	/// <summary>
	/// Factors are the values which results 0 when they get divided to a number.
	/// </summary>
	public class Factors
	{
		public Factors ()
		{
		}

		public System.Collections.ArrayList FindFactors( int num)
		{
			if (num < 1) {
				return null;
			}
			System.Collections.ArrayList list = new System.Collections.ArrayList ();
			for (int i = 1; i <= num; i++) {
				if (num % i == 0) {
					list.Add (i);
				}
			}
			return list;
		}
	}
}

