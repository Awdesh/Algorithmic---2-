using System;
using System.Collections.Generic;

namespace Tree
{
	public class MaxHeight
	{
		public MaxHeight ()
		{
		}

		/// <summary>
		/// Finds the height of the max. Uses BFS internally.
		/// </summary>
		/// <returns>The max height.</returns>
		/// <param name="root">Root.</param>
		public int FindMaxHeight(TreeNode root)
		{
			if (root == null) {
				return 0;
			}
			Queue<TreeNode> q = new Queue<TreeNode> ();
			q.Enqueue (root);
			int maxHeight = 0;
			root.setLevel (0);
			while (q.Count>0) {
				TreeNode t = q.Dequeue ();
				if (t == null) {
					break;
				}
				int currentHeight = t.getLevel ();
				if (t.getLeft () != null) {
					t.getLeft().setLevel (currentHeight + 1);
					q.Enqueue (t.getLeft());
				}
				if (t.getRight () != null) {
					t.getRight().setLevel (currentHeight + 1);
					q.Enqueue (t.getRight());
				}
				// this would be extra cheack apart from regular BFS.
				if (maxHeight < currentHeight) {
					maxHeight = currentHeight;
				}
			}
			return maxHeight;
		}

		/// <summary>
		/// Finds the max height recursion.
		/// </summary>
		/// <returns>The max height recursion.</returns>
		/// <param name="root">Root.</param>
		public int FindMaxHeightRecursion(TreeNode root)
		{
			if (root == null) {
				return 0;
			}
			return 1 + Math.Max(FindMaxHeight(root.getLeft()) , FindMaxHeight(root.getRight()));
		}
	}
}

