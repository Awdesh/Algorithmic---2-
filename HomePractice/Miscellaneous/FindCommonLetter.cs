	using System;

namespace Miscellaneous
{
	public class FindCommonLetter
	{
		public FindCommonLetter ()
		{
		}

		public void FindCommon(string s1, string s2)
		{
			if(s1 == null || s2 == null)
			{
				return;    
			}
			if(s1.Length < 1 || s2.Length < 1)
			{
				return;    
			}
			bool[] flag = new bool[27];
			for(int i = 0; i <s1.Length; i++)
			{
				int val = s1[i] - 97;
				if (!flag [val]) {
					flag [val] = true;
				}
			}
			for(int i = 0; i <s2.Length;i++)
			{
				int val = s2[i] - 97;
				if (flag [val]) {
					Console.WriteLine ("YES");
					return;
				}
			}
			Console.WriteLine ("NO");
		}
	}
}

