//using System;
//
//namespace Tree
//{
//	public class SmallestValueBT
//	{
//		public SmallestValueBT ()
//		{
//		}
//
//		public int FindSmallestValue(TreeNode root)
//		{
//			if (root == null) {
//				return 0;
//			}
//			int leftMin = FindSmallestValue (root.getLeft ());
//			int rightMin = FindSmallestValue (root.getRight ());
//			
			int min = Math.min(leftMin, rightMin);
			return min;
//		}
//	}
//}
//
