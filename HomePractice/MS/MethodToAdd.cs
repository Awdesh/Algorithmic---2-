using System;

namespace MSSelection
{
	public class MethodToAdd
	{
		public MethodToAdd ()
		{

		}

		public string demo(string s1, string s2)
		{
			int n1 = StringToInt.ConvertStringToInt (s1);
			int n2 = StringToInt.ConvertStringToInt (s2);
			int sum = n1 + n2;

			string s = IntToString.Converter (sum);
			return s;
		}
	}
}

