using System;

namespace Tree
{
	public class LCA
	{
		public LCA ()
		{
		}

		/// <summary>
		/// Finds the lowest common ancestor. of BST.
		/// </summary>
		/// <returns>The lowest common ancestor.</returns>
		/// <param name="root">Root.</param>
		/// <param name="val1">Val1.</param>
		/// <param name="val2">Val2.</param>
		public int FindLowestCommonAncestor(TreeNode root,int val1, int val2)
		{
			if (root == null) {
				return 0;
			}
			if (root.getData () > val1 && root.getData() > val2) {
				// We need return for recursive calls of functions.
				return FindLowestCommonAncestor (root.getLeft(), val1, val2);
			}
			if (root.getData () < val1 && root.getData () < val2) {
				return FindLowestCommonAncestor (root.getRight(), val1, val2);
			} else {
				return root.getData ();
			}
		}

		/// <summary>
		/// 	
		/// </summary>
		/// <returns>The LCA of BT, Not BST</returns>
		/// <param name="root">Root.</param>
		/// <param name="val1">Val1.</param>
		/// <param name="val2">Val2.</param>
		public TreeNode FindLCAofBT(TreeNode root, int val1, int val2)
		{
			if (root == null) {
				return null;
			}

			if (root.getData () == val1 || root.getData () == val2) {
				return root;
			}
			TreeNode left_lca = FindLCAofBT (root.getLeft (), val1, val2);
			TreeNode right_lca = FindLCAofBT (root.getRight (), val1, val2);

			// if both are non null that means we have nodes in two different sub trees from root.
			if (left_lca!= null && right_lca != null) {
				return root;
			}

			// either left_lca or right_lca whichever is non-null would have value of lca.
			return (left_lca != null) ? left_lca : right_lca;
		}
	}
}

