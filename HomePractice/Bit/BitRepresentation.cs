using System;

namespace Bit
{
	public class BitRepresentation
	{
		public BitRepresentation ()
		{
		}

		public void Represent(uint num)
		{
			string s = Convert.ToString (num, 2).PadLeft(32, '0');
			char[] chArr = s.ToCharArray ();
			uint number = Convert.ToUInt32(s, 16);

			for (int i = 0; i< chArr.Length; i++) {
				Console.Write ("{0}", chArr[i]);
			}
		}
	}
}

