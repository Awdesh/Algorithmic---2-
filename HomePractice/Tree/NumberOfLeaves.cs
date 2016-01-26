using System;

namespace Tree
{
	public class NumberOfLeaves
	{
		public NumberOfLeaves ()
		{
		}

		public int CountNumberOfLeaves(TreeNode root)
		{
			if (root == null) {
				return 0;
			}
			// Base case.
			if (root.getLeft () == null && root.getRight () == null) {
				return 1;
			} else {
				return CountNumberOfLeaves (root.getLeft ()) + CountNumberOfLeaves (root.getRight ());
			}
		}

		public void PrintPaths(int[] path, TreeNode root, int len)
		{
			if (root == null) {
				return;
			}
			path [len] = root.getData();
			len++;

			if (root.getLeft () == null && root.getRight () == null) {
				PrintArray (path, len);
				return;
			}

			PrintPaths (path, root.getLeft(), len);
			PrintPaths (path, root.getRight (), len);
		}

		// Print array.
		public void PrintArray(int[] path, int len)
		{
			for (int i = 0; i<len; i++) {
				Console.WriteLine(path[i]);
			}
		}
	}
}

