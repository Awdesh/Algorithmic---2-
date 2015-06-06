/// <summary>
/// Given an array of integers, find two numbers such that they add up to a specific target number.

/*The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.

	You may assume that each input would have exactly one solution.

		Input: numbers={2, 7, 11, 15}, target=9
	Output: index1=1, index2=2  */
/// </summary>

using System;
using System.Collections.Generic;
using System.Resources;

namespace HomePractice
{
	public class Solution {


		/// <summary>
		/// Twos the sum.
		/// </summary>
		/// <returns>The sum.</returns>
		/// <param name="numbers">Numbers.</param>
		/// <param name="target">Target.</param>
		public Tuple<int, int> TwoSum(int[] numbers, int target) {

			int Length = numbers.Length;
			var tuple = Tuple.Create(0,0);
			if(Length <= 1 )
			{
				return tuple;
			}

			for(int i = 0; i + 1 < Length; i++)
			{
				int j = i + 1;
				while(j < Length)
				{
					if(numbers[i] + numbers[j] == target)
					{
						// add to tuple.
						tuple = Tuple.Create(i+1,j+1);
						return tuple;
					}
//					else 
//					{
//						if(numbers[i] + numbers[j] > target)
//						{
//							tuple = Tuple.Create (0,0);
//							//return tuple;
//						}
//					}        
					j++;
				}
			}
			return tuple;
		}

		/// <summary>
		/// Twos the sum.
		/// </summary>
		/// <returns>The sum.</returns>
		/// <param name="numbers">Numbers.</param>
		/// <param name="integers">Integers.</param>
		public Tuple<int,int> TwoSumOptimized(int[] numbers, int integers)
		{
			Dictionary<int,int> dict = new Dictionary<int, int> ();
			var tuple = Tuple.Create (0, 0);
			for (int i = 0; i < numbers.Length; i++) {
				if(!dict.ContainsKey(numbers[i]))
			    {
					dict.Add (i + 1, numbers [i]);
				}
			}

//			foreach (var pair in dict) {
//				int data = integers - (pair.Value);
//				if (dict.ContainsValue (data) && data != pair.Value) {
//
//					tuple = Tuple.Create ( pair.Key, key );
//				}
//			}
			return tuple;
		}
	}
}

