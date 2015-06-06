using System;

namespace MSSelection
{
	public class StringSplit
	{
		public StringSplit ()
		{
		}

		public void SplitAString(string s)
		{
			int count = 0;
			bool isValid = false;
			// Separate strings with delimiters given inside an array.
			string[] equationsTokens = s.Split (new char[] {'.'});
			foreach(string s1 in equationsTokens)
			{
				count ++;
				Console.WriteLine(s1);
			}
			if (count != 3) {
				return;
			}
		}

		public bool IsValidIp(string s)
		{
			int count = 0;
			string[] tokens = s.Split (new char[] {'.'});
			foreach (string s1 in tokens) {

				if (! IsValidDigit (s1)) {
					return false;
				}

				int num = ConvertStringToInt (s1);

				if (num >= 0 && num <= 255) {
					++count;
				} else {
					return false;
				}
			}

			if (count - 1 != 3) {
				return false;
			}

			return true;
		}

		public int ConvertStringToInt(string s)
		{
			int i = 0;
			int num = 0;
			bool isNeg = false;

			if (s [0] == '-') {
				isNeg = true;
			}

			while (i <s.Length) {
				num = num * 10;
				num += s [i] - '0'; // num + (s[i] - '0');
				i++;
			}

			if (isNeg) {
				num *= -1;
			}

			return num;
		}

		private bool IsValidDigit(string s)
		{
			foreach (char c in s) {
				if (!(c >= '0' && c <= '9')) {
					return false;
				}
			}
			return true;
		}
	}
}

