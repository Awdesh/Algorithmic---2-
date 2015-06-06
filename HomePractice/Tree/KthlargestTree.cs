using System;	
using System.Collections.Generic;

namespace Tree
{
	public class KthlargestTree
	{
		List<TreeNode> list = new List<TreeNode> ();
		public KthlargestTree ()
		{
		}

		/// <summary>
		/// Finds the node.
		/// </summary>
		/// <returns>The node.</returns>
		/// <param name="node">Node.</param>
		public void FindNode(TreeNode root)
		{
			if (root == null) {
				return;
			}

			FindNode (root.getLeft ());
			list.Add (root);
			Console.WriteLine (root.getData ());
			FindNode (root.getRight ());
		}

		/// <summary>
		/// Largests the value.
		/// </summary>
		/// <returns>The value.</returns>
		/// <param name="root">Root.</param>
		/// <param name="k">K.</param>
		public TreeNode LargestValue(TreeNode root, int k)
		{
			FindNode (root);
			return list [list.Count - k];
		}

		/// <summary>
		/// Smallests the value.
		/// </summary>
		/// <returns>The value.</returns>
		/// <param name="root">Root.</param>
		/// <param name="k">K.</param>
		public TreeNode SmallestValue(TreeNode root, int k)
		{
			FindNode (root);
			return list [k - 1];
		}
	}
}

