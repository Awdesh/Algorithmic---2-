using System;
using System.Collections.Generic;

namespace Tree
{
	public class PreOrderTraversal
	{
		public PreOrderTraversal ()
		{
		}


		/// <summary>
		/// NLR
		/// </summary>
		/// <param name="root">Root.</param>
		public void RecursiveTraversal(TreeNode root)
		{
			if (root == null) {
				return;
			}
			Console.WriteLine (root.getData ());
			RecursiveTraversal(root.getLeft());
			RecursiveTraversal (root.getRight ());
		}

		/// <summary>
		/// Non-recursive traversal, using stack
		/// </summary>
		/// <param name="root">Root.</param>
		public void NonRecursiveTraversal(TreeNode root)
		{
			if (root == null) {
				return;
			}
			TreeNode temp;
			Stack<TreeNode> s = new Stack<TreeNode> ();
			s.Push (root);
			while (s.Count > 0) {
				temp = s.Pop ();
				Console.WriteLine (temp.getData ());
				if (temp == null) {
					return;
				}
				if (temp.getRight () != null) {
					s.Push (temp.getRight());
				}
				if (temp.getLeft () != null) {
					s.Push (temp.getLeft());
				}
			}

		}
	}
}

