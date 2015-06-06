using System;

namespace Tree
{
	public class LargestValueInBT
	{
		public LargestValueInBT ()
		{
		}

		public int FindLargestValueInBinrayTree(TreeNode root)
		{
			if (root == null) {
				return 0;
			}

			int max = root.getData ();

			if (root.getLeft () != null) {
				max = Math.Max (max, FindLargestValueInBinrayTree (root.getLeft ()));
			}
			if (root.getRight () != null) {
				max = Math.Max (max, FindLargestValueInBinrayTree (root.getRight ()));
			}
			return max;
		}
	}
}

