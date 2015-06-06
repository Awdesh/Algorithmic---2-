using System;

namespace MSSelection
{
	public class StringToInt
	{
		public StringToInt ()
		{
		}

		public static int ConvertStringToInt(string s)
		{
			int i = 0;
			int num = 0;
			bool isNeg = false;

			if (s [0] == '-') {
				isNeg = true;
			}

			while (i <s.Length) {
				num = num * 10;
				num += s [i] - '0';
				i++;
			}

			if (isNeg) {
				num *= -1;
			}

			return num;
		}
	}
}

