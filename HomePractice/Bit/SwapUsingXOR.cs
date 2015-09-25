using System;

namespace Bit
{
	public class SwapUsingXOR
	{
		public SwapUsingXOR ()
		{
		}
		/// <summary>
		/// Swap the specified a and b using XOR.
		/// </summary>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public void Swap(int a, int b)
		{
			a = a ^ b;
			b = a ^ b;
			a = a ^ b;

			Console.WriteLine ("{0}", a);
			Console.WriteLine ("{0}", b);
		}
	}
}

