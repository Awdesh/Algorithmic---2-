using System;
using Tree;

namespace Tree
{
	public class FindNodeValue
	{
		public FindNodeValue ()
		{
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
		public bool IsValueExists(TreeNode node, int value)
		{
			while (node != null) 
            {
				if (node == null) 
					return false;
				if (node.getData () == value)
					return true;
				if (node.getData() > value)
					node = node.getLeft ();
				else // if we've used if(node.getData() < Value) then it would have errored out here 
					//because on in case above if have resulted node == null it would have calculate null.getData() here which is an error.
					node = node.getRight ();
			}
			return false;
		}

		/// <summary>
		/// Recursive Approach.
		/// </summary>
		/// <returns><c>true</c> if this instance is value exists recursive the specified root value; otherwise, <c>false</c>.</returns>
		/// <param name="root">Root.</param>
		/// <param name="value">Value.</param>
		public bool IsValueExistsRecursive(TreeNode root, int value)
		{
			if (root == null) {
				return false;
			}
			int val = root.getData ();
            // Base case.
			if (val == value) {
				return true;
			}
			if (val > value) {
				return IsValueExistsRecursive (root.getLeft (), value);
			}
			else 
            {
				return IsValueExistsRecursive (root.getRight (), value);
			}
		}
	}
}

