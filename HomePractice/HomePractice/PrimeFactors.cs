using System;

namespace HomePractice
{
	public class PrimeFactors
	{
		public PrimeFactors ()
		{

		}

		public System.Collections.ArrayList FindPrimeFactors(int num)
		{
			System.Collections.ArrayList List = new System.Collections.ArrayList ();
			if (num < 1) {
				return null;
			}
			for (int i = 1; i < num; i++) {
				if (num % i == 0) {
					for (int j = 2; j < i; j++) {
						if (i % j == 0) {
							continue;
						}
						List.Add (i);
					}
					num = num / i;
				}
			}
			return List;
		}
	}
}

