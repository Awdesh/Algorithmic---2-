using System;

namespace Bit
{
	public class LonelyInteger
	{
		public LonelyInteger ()
		{
		}

		/// <summary>
		/// Finds the only unique number in an array.
		/// </summary>
		/// <returns>The number.</returns>
		/// <param name="arr">Arr.</param>
		public int FindNumber(int[] arr)
		{
			int len = arr.Length;
			int lonelyInt = 0;

			for (int i = 0; i < len; i++) 
			{
				lonelyInt = lonelyInt ^ arr [i];
			}

			return lonelyInt;
		}
	}
}

