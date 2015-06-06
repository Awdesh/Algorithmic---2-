//using System;
//
//namespace MSSelection
//{
//	public class RemoveDupSortedArray
//	{
//		public RemoveDupSortedArray ()
//		{
//		}
//
//		public int[] RemoveDups(int[] input)
//		{
//			int prev = 0;
//			int current = 1;
//
//			for (int i = 0; i < input.Length; i++) {
//				if(input[prev] != input[current]){
//					prev++;
//					input[prev] = input[current];
//					current++;
//                  }
//				else{
//
//					current++;
//				}
//          }
//		}
//	}
//}
//
