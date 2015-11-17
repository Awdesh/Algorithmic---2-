using System;
using System.Collections.Generic;

namespace Miscellaneous
{
	public class AddBinary
	{
		/// <summary>
		/// Converts the string to int.
		/// </summary>
		/// <returns>The string to int.</returns>
		/// <param name="s">S.</param>
		private static int ConvertStringToInt(string s)
		{
			bool isNeg = false;
			char[] chArr = s.ToCharArray();
			if(chArr[0] == '-')
				isNeg = true;

			int len = chArr.Length;
			int num = 0;
			for(int i = 0; i < len; i++)
			{
				if(chArr[i] == '-')
					continue;
				int val = chArr[i] - '0';
				num = num * 10 + val;
			}

			if (isNeg)
				num *= -1;

			return num;
		}

		/// <summary>
		/// Multiplies the two strings.
		/// </summary>
		/// <returns>The two strings.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static int MultiplyTwoStrings(string a, string b)
		{
			int num1 = ConvertStringToInt (a);
			int num2 = ConvertStringToInt (b);
			return num1 * num2;
		}

		public static bool IsInterleave(string s1, string s2, string s3)
		{
			char[] chArr1 = s1.ToCharArray();
			char[] chArr2 = s2.ToCharArray();

			Dictionary<char,int> map = new Dictionary<char,int>();
			foreach(char c in chArr1)
			{
				if(!map.ContainsKey(c))
					map.Add(c,1);
				else
					map[c]++;
			}

			foreach(char c in chArr2)
			{
				if(!map.ContainsKey(c))
					map.Add(c,1);
				else
					map[c]++;
			}

			foreach(char c in s3.ToCharArray())
			{
				if(map.ContainsKey(c))
				{
					map[c]--;
					if(map[c] == 0)
						map.Remove(c);
				}
			}
			return map.Count == 0;
		}

		/// <summary>
		/// Using Dictionary.	
		/// </summary>
		/// <returns>The string.</returns>
		/// <param name="ip">Ip.</param>
		public static string CompressString(string ip)
		{
			if (ip.Length == 1)
				return ip;

			Dictionary<char,int> map = new Dictionary<char, int> ();
			foreach (char c in ip.ToCharArray()) 
			{
				if (!map.ContainsKey (c))
					map.Add (c, 1);
				else
					map [c]++;
			}

			System.Text.StringBuilder sb = new System.Text.StringBuilder ();
			foreach (char c in map.Keys) 
			{
				if (map [c] == 1) {
					sb.Append (c);
					continue;
				}

				sb.Append (c);
				sb.Append (map[c]);
			}

			return sb.ToString ();
		}

		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		static void Main(string[] args)
		{
			string v = CompressString ("aa");
			Console.WriteLine (v);
		}
	}
}

