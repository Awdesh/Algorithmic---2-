using System;

namespace Miscellaneous
{
	public class CardShuffle
	{
		public CardShuffle ()
		{
		}

		public int[] ShuffleCards(int[] cards)
		{
			int startIndex = 0;
			int endIndex = cards.Length - 1;

			Random random = new Random ();

			//O(n).
			for (int i = startIndex; i < endIndex; i++) 
			{
				int next = random.Next (startIndex, endIndex);
				// swap elements.
				int temp = cards [next];
				cards [next] = cards [i];
				cards [i] = temp; 
			}

			return cards;
		}
	}
}

