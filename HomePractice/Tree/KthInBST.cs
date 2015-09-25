using System;
using System.Collections.Generic;

namespace Tree
{
	public class KthInBST
	{
		public KthInBST ()
		{
		}

		/// <summary>
		/// Find the specified root and k., simple inorder traversal and checking count while popping elements.
		/// </summary>
		/// <param name="root">Root.</param>
		/// <param name="k">K.</param>
		public TreeNode Find(TreeNode root, int k)
		{
			if (root == null) {
				return null;
			}

			TreeNode temp = root;
			Stack<TreeNode> s = new Stack<TreeNode> ();
			bool found = false;
			int count = 0;

			while (!found) {

				if (temp != null) {
					s.Push (temp);
					temp = temp.getLeft ();
				} else if (s.Count > 0) {
					TreeNode n = s.Pop ();
					if (n != null) {
						count++;
						temp = n.getRight ();
					}

					if (count == k) {
						return n;
					} 
				} else {
					found = true;
				}
			}

			return null;
		}
	}
}

