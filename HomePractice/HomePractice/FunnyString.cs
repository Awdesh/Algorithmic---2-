using System;

namespace HomePractice
{
	public class FunnyString
	{
		public FunnyString ()
		{
		}

		public void ParseString(string inde)
		{
			int index = Convert.ToInt32(inde);
			for(int i = 1; i <= index; i++)
			{
				if(FindString(Console.ReadLine()))
				{
					Console.WriteLine("Funny");
				}
				else
				{
					Console.WriteLine("Not Funny");
				}
			}
		}

		public bool FindString(string s1)
		{
			for(int i = 0; i < s1.Length - 1; i++)
			{
				int a = s1 [i + 1] - s1 [i];
				char[] ch = s1.ToCharArray ();
				Array.Reverse (ch);

				int b = ch [i + 1] - ch [i];
				if(Math.Abs(a) != Math.Abs(b))
				{
					return false;
				}   
			}
			return true;
		}
	}
}
