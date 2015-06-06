using System;

namespace Tree
{
	public class NumberofNodes
	{
		public NumberofNodes ()
		{
		}

		public int CalculateTotalNodes(TreeNode root)
		{
			// Base case.
			if (root == null) {
				return 0;
			}

			// Need to add 1, so that root will get counted too.
			return 1 + CalculateTotalNodes (root.getLeft ()) + CalculateTotalNodes (root.getRight ());
		}
	}
}

