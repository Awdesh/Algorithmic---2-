using System;

namespace Miscellaneous
{
	public class ReverseStringPreserveSpace
	{
		public ReverseStringPreserveSpace ()
		{
		}

		public string Reverse(string s)
		{
			int i = 0;
			int j = s.Length - 1;
			char[] chArr = s.ToCharArray ();

			while (i < j) {
				if (chArr [i] == ' ') 
				{
					i++;
					continue;
				}

				if (chArr [j] == ' ') 
				{
					j--;
					continue;
				}

				char temp = chArr [i];
				chArr [i] = chArr [j];
				chArr [j] = temp;
				i++;
				j--;
			}
			return chArr.ToString();
		}
	}
}

